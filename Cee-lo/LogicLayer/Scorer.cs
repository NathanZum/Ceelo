using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Scorer
    {
        public int compareScores(int playerScore, int comScore)
        {
            return playerScore - comScore;
        }

        public String resultMessage(int result)
        {
            String message = "";
            //win message
            if (result > 0)
            {
                message = "\n\n YOU WIN";
            }
            //loss message
            else if (result < 0)
            {
                message = "\n\n YOU LOSE";
            }
            //tie message
            else
            {
                message = "\n\n IT'S A TIE";
            }
            return message;
        }

        public int payPlayer(int result, int playerBank, int pot)
        {
            int bank = playerBank;
            if(result > 0)
            {
                bank += pot;
            }
            else if (result == 0)
            {
                bank += pot / 2;
            }
            return bank;
        }

        public int payCom(int result, int comBank, int pot)
        {
            int bank = comBank;
            if (result < 0)
            {
                bank += pot;
            }
            else if (result == 0)
            {
                bank += pot / 2;
            }
            return bank;
        }
    }
}
