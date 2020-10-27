namespace part_8_hangman
{
    partial class frmHangman
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lstUsedLetters = new System.Windows.Forms.ListBox();
            this.lblWord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::part_8_hangman.Properties.Resources.blank_man;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(233, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(235, 37);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Hang-Man Lite!";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(368, 252);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 20);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Check?";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(219, 252);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(143, 20);
            this.txtGuess.TabIndex = 3;
            // 
            // lstUsedLetters
            // 
            this.lstUsedLetters.FormattingEnabled = true;
            this.lstUsedLetters.Location = new System.Drawing.Point(219, 60);
            this.lstUsedLetters.Name = "lstUsedLetters";
            this.lstUsedLetters.Size = new System.Drawing.Size(249, 186);
            this.lstUsedLetters.TabIndex = 4;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(12, 275);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(87, 37);
            this.lblWord.TabIndex = 5;
            this.lblWord.Text = "word";
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 315);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lstUsedLetters);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmHangman";
            this.Text = "Hangman-Lite!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.ListBox lstUsedLetters;
        private System.Windows.Forms.Label lblWord;
    }
}

