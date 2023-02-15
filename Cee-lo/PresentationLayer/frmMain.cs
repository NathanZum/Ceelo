using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using LogicLayer;
using DataObjects;

namespace PresentationLayer
{
    public partial class frmMain : Form
    {

        private ResourceManager _rm = new ResourceManager(
            "PresentationLayer.ResourceImages", Assembly.GetExecutingAssembly());
        //player bank
        private int _playerBank = 500;
        //com bank
        private int _comBank = 500;
        //money pot
        private int _pot = 0;
        //players set of dice
        private DiceSet _playerSet;
        //coms set of dice
        private DiceSet _comSet;
        //roller
        private Roller _roller = new Roller();
        //scorer
        private Scorer _scorer = new Scorer();
        //banker
        private Banker _banker = new Banker();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            resetDiceDisplay();
        }

        private void resetDiceDisplay()
        {
            lblPlayerBank.Text = _playerBank.ToString();
            lblComBank.Text = _comBank.ToString();
            _pot = 0;
            lblPot.Text = _pot.ToString();
            numBet.Value = 1;
            numBet.Maximum = _playerBank >= _comBank ? _comBank : _playerBank;

            picPlayerDice1.Image = (Image)_rm.GetObject("one");
            picPlayerDice2.Image = (Image)_rm.GetObject("one");
            picPlayerDice3.Image = (Image)_rm.GetObject("one");
            picComDice1.Image = (Image)_rm.GetObject("one");
            picComDice2.Image = (Image)_rm.GetObject("one");
            picComDice3.Image = (Image)_rm.GetObject("one");

            lblDice1.Text = "";
            lblDice2.Text = "";
            lblDice3.Text = "";
            lblDice4.Text = "";
            lblDice5.Text = "";
            lblDice6.Text = "";

            btnRoll.Enabled = true;
            btnScore.Enabled = false;
            numBet.Enabled = true;

            statusLabel.Text = "Place bet and press 'Roll' to begin";
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int _bet = (int)numBet.Value;
            _playerBank = _playerBank - _bet;
            _comBank = _comBank - _bet;
            lblPlayerBank.Text = _playerBank.ToString();
            lblComBank.Text = _comBank.ToString();
            _pot = _bet * 2;
            lblPot.Text = _pot.ToString();
            btnScore.Enabled = true;
            btnRoll.Enabled = false;
            numBet.Enabled = false;
            _playerSet = _roller.NewSet();
            displayPlayerDice();
            _comSet = _roller.NewSet();
            displayComDice();

            statusLabel.Text = "Press 'Score' to continue";
        }

        private void displayPlayerDice()
        {
            Dice dice = _playerSet.Dices[0];
            picPlayerDice1.Image = (Image)_rm.GetObject(dice.ImageName);
            lblDice1.Text = dice.ToString();

            dice = _playerSet.Dices[1];
            picPlayerDice2.Image = (Image)_rm.GetObject(dice.ImageName);
            lblDice2.Text = dice.ToString();

            dice = _playerSet.Dices[2];
            picPlayerDice3.Image = (Image)_rm.GetObject(dice.ImageName);
            lblDice3.Text = dice.ToString();
        }

        private void displayComDice()
        {
            Dice dice = _comSet.Dices[0];
            picComDice1.Image = (Image)_rm.GetObject(dice.ImageName);
            lblDice4.Text = dice.ToString();

            dice = _comSet.Dices[1];
            picComDice2.Image = (Image)_rm.GetObject(dice.ImageName);
            lblDice5.Text = dice.ToString();

            dice = _comSet.Dices[2];
            picComDice3.Image = (Image)_rm.GetObject(dice.ImageName);
            lblDice6.Text = dice.ToString();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            int playerScore = (int)_playerSet.scoreSet();
            int comScore = (int)_comSet.scoreSet();
            int result = _scorer.compareScores(playerScore, comScore);

            String playerResult = Enum.GetName(typeof(SetScores), _playerSet.scoreSet());
            String comResult = Enum.GetName(typeof(SetScores), _comSet.scoreSet());

            playerResult = playerResult.Replace('_', ' ');
            comResult = comResult.Replace('_', ' ');

            _playerBank = _scorer.payPlayer(result, _playerBank, _pot);
            _comBank = _scorer.payCom(result, _comBank, _pot);

            MessageBox.Show("You got a " + playerResult + "\nYour score is: " + playerScore +
                "\n\nCom got a " + comResult + "\nCom score is: " + comScore +
                _scorer.resultMessage(result), 
                "Results", MessageBoxButtons.OK);

            if (_playerBank == 0)
            {
                MessageBox.Show("You lose!\n\nClick OK to start a new game", "Bankrupt",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _playerBank = 500;
                _comBank = 500;
                numBet.Value = 1;
            }
            else if (_comBank == 0)
            {
                MessageBox.Show("You Win!\n\nClick OK to start a new game", "Com Bankrupt",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _playerBank = 500;
                _comBank = 500;
                numBet.Value = 1;
            }

            resetDiceDisplay();
        }

        private void newGameMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will end your current game.", "New Game",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                _playerBank = 500;
                _comBank = 500;
                numBet.Value = 1;
                resetDiceDisplay();
            }
        }

        private void quitGameMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit Game",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void howToPlayMenuItem_Click(object sender, EventArgs e)
        {
            frmHowToPlay howToPlay = new frmHowToPlay();
            howToPlay.ShowDialog();
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_banker.SaveBank(_playerBank, _comBank))
                {
                    MessageBox.Show("Bank Saved.", "Save Bank",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }
        }

        private void loadMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int[] banks = _banker.RestoreBanks();
                _playerBank = banks[0];
                _comBank = banks[1];
                lblPlayerBank.Text = _playerBank.ToString();
                lblComBank.Text = _comBank.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.InnerException.Message);
            }
        }
    }
}
