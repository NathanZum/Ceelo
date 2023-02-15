namespace PresentationLayer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.numBet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerBank = new System.Windows.Forms.Label();
            this.lblComBank = new System.Windows.Forms.Label();
            this.lblDice4 = new System.Windows.Forms.Label();
            this.lblDice3 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice5 = new System.Windows.Forms.Label();
            this.lblDice6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPot = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picComDice3 = new System.Windows.Forms.PictureBox();
            this.picComDice2 = new System.Windows.Forms.PictureBox();
            this.picComDice1 = new System.Windows.Forms.PictureBox();
            this.picPlayerDice3 = new System.Windows.Forms.PictureBox();
            this.picPlayerDice2 = new System.Windows.Forms.PictureBox();
            this.picPlayerDice1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(274, 322);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(115, 58);
            this.btnRoll.TabIndex = 6;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(416, 322);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(115, 58);
            this.btnScore.TabIndex = 7;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // numBet
            // 
            this.numBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBet.Location = new System.Drawing.Point(69, 332);
            this.numBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBet.Name = "numBet";
            this.numBet.Size = new System.Drawing.Size(120, 22);
            this.numBet.TabIndex = 8;
            this.numBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player Bet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Player Bank:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "COM Bank:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerBank
            // 
            this.lblPlayerBank.BackColor = System.Drawing.Color.Snow;
            this.lblPlayerBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerBank.Location = new System.Drawing.Point(124, 270);
            this.lblPlayerBank.Name = "lblPlayerBank";
            this.lblPlayerBank.Size = new System.Drawing.Size(109, 23);
            this.lblPlayerBank.TabIndex = 12;
            this.lblPlayerBank.Text = "player";
            this.lblPlayerBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComBank
            // 
            this.lblComBank.BackColor = System.Drawing.Color.Snow;
            this.lblComBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComBank.Location = new System.Drawing.Point(570, 270);
            this.lblComBank.Name = "lblComBank";
            this.lblComBank.Size = new System.Drawing.Size(106, 23);
            this.lblComBank.TabIndex = 13;
            this.lblComBank.Text = "com";
            this.lblComBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDice4
            // 
            this.lblDice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice4.Location = new System.Drawing.Point(455, 111);
            this.lblDice4.Name = "lblDice4";
            this.lblDice4.Size = new System.Drawing.Size(109, 23);
            this.lblDice4.TabIndex = 14;
            this.lblDice4.Text = "Dice4";
            this.lblDice4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDice3
            // 
            this.lblDice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice3.Location = new System.Drawing.Point(237, 111);
            this.lblDice3.Name = "lblDice3";
            this.lblDice3.Size = new System.Drawing.Size(109, 23);
            this.lblDice3.TabIndex = 15;
            this.lblDice3.Text = "Dice3";
            this.lblDice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDice2
            // 
            this.lblDice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice2.Location = new System.Drawing.Point(124, 111);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(109, 23);
            this.lblDice2.TabIndex = 16;
            this.lblDice2.Text = "Dice2";
            this.lblDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDice1
            // 
            this.lblDice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice1.Location = new System.Drawing.Point(12, 111);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(109, 23);
            this.lblDice1.TabIndex = 17;
            this.lblDice1.Text = "Dice1";
            this.lblDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDice5
            // 
            this.lblDice5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice5.Location = new System.Drawing.Point(570, 111);
            this.lblDice5.Name = "lblDice5";
            this.lblDice5.Size = new System.Drawing.Size(109, 23);
            this.lblDice5.TabIndex = 18;
            this.lblDice5.Text = "Dice5";
            this.lblDice5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDice6
            // 
            this.lblDice6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice6.Location = new System.Drawing.Point(679, 111);
            this.lblDice6.Name = "lblDice6";
            this.lblDice6.Size = new System.Drawing.Size(109, 23);
            this.lblDice6.TabIndex = 19;
            this.lblDice6.Text = "Dice6";
            this.lblDice6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.howToPlayMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem,
            this.loadMenuItem,
            this.newGameMenuItem,
            this.quitGameMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadMenuItem.Text = "Load";
            this.loadMenuItem.Click += new System.EventHandler(this.loadMenuItem_Click);
            // 
            // howToPlayMenuItem
            // 
            this.howToPlayMenuItem.Name = "howToPlayMenuItem";
            this.howToPlayMenuItem.Size = new System.Drawing.Size(84, 20);
            this.howToPlayMenuItem.Text = "How To Play";
            this.howToPlayMenuItem.Click += new System.EventHandler(this.howToPlayMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = " ";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Snow;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(118, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // lblPot
            // 
            this.lblPot.BackColor = System.Drawing.Color.Snow;
            this.lblPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPot.Location = new System.Drawing.Point(343, 86);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(109, 23);
            this.lblPot.TabIndex = 23;
            this.lblPot.Text = "player";
            this.lblPot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Pot:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newGameMenuItem
            // 
            this.newGameMenuItem.Name = "newGameMenuItem";
            this.newGameMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameMenuItem.Text = "New Game";
            this.newGameMenuItem.Click += new System.EventHandler(this.newGameMenuItem_Click);
            // 
            // quitGameMenuItem
            // 
            this.quitGameMenuItem.Name = "quitGameMenuItem";
            this.quitGameMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitGameMenuItem.Text = "Quit Game";
            this.quitGameMenuItem.Click += new System.EventHandler(this.quitGameMenuItem_Click);
            // 
            // picComDice3
            // 
            this.picComDice3.Location = new System.Drawing.Point(691, 137);
            this.picComDice3.Name = "picComDice3";
            this.picComDice3.Size = new System.Drawing.Size(86, 89);
            this.picComDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComDice3.TabIndex = 5;
            this.picComDice3.TabStop = false;
            // 
            // picComDice2
            // 
            this.picComDice2.Location = new System.Drawing.Point(579, 137);
            this.picComDice2.Name = "picComDice2";
            this.picComDice2.Size = new System.Drawing.Size(86, 89);
            this.picComDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComDice2.TabIndex = 4;
            this.picComDice2.TabStop = false;
            // 
            // picComDice1
            // 
            this.picComDice1.Location = new System.Drawing.Point(468, 137);
            this.picComDice1.Name = "picComDice1";
            this.picComDice1.Size = new System.Drawing.Size(86, 89);
            this.picComDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComDice1.TabIndex = 3;
            this.picComDice1.TabStop = false;
            // 
            // picPlayerDice3
            // 
            this.picPlayerDice3.Location = new System.Drawing.Point(249, 137);
            this.picPlayerDice3.Name = "picPlayerDice3";
            this.picPlayerDice3.Size = new System.Drawing.Size(87, 89);
            this.picPlayerDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerDice3.TabIndex = 2;
            this.picPlayerDice3.TabStop = false;
            // 
            // picPlayerDice2
            // 
            this.picPlayerDice2.Location = new System.Drawing.Point(136, 137);
            this.picPlayerDice2.Name = "picPlayerDice2";
            this.picPlayerDice2.Size = new System.Drawing.Size(87, 89);
            this.picPlayerDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerDice2.TabIndex = 1;
            this.picPlayerDice2.TabStop = false;
            // 
            // picPlayerDice1
            // 
            this.picPlayerDice1.Location = new System.Drawing.Point(24, 137);
            this.picPlayerDice1.Name = "picPlayerDice1";
            this.picPlayerDice1.Size = new System.Drawing.Size(87, 89);
            this.picPlayerDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerDice1.TabIndex = 0;
            this.picPlayerDice1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblDice6);
            this.Controls.Add(this.lblDice5);
            this.Controls.Add(this.lblDice1);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice3);
            this.Controls.Add(this.lblDice4);
            this.Controls.Add(this.lblComBank);
            this.Controls.Add(this.lblPlayerBank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBet);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picComDice3);
            this.Controls.Add(this.picComDice2);
            this.Controls.Add(this.picComDice1);
            this.Controls.Add(this.picPlayerDice3);
            this.Controls.Add(this.picPlayerDice2);
            this.Controls.Add(this.picPlayerDice1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Cee-lo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerDice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayerDice1;
        private System.Windows.Forms.PictureBox picPlayerDice2;
        private System.Windows.Forms.PictureBox picPlayerDice3;
        private System.Windows.Forms.PictureBox picComDice3;
        private System.Windows.Forms.PictureBox picComDice2;
        private System.Windows.Forms.PictureBox picComDice1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.NumericUpDown numBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerBank;
        private System.Windows.Forms.Label lblComBank;
        private System.Windows.Forms.Label lblDice4;
        private System.Windows.Forms.Label lblDice3;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice5;
        private System.Windows.Forms.Label lblDice6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem newGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitGameMenuItem;
    }
}

