using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_8_hangman
{
    public partial class frmHangman : Form
    {
        string word;
        int guessCounter;
        string displayWord;


        public frmHangman()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            word = "COMPUTER";
            guessCounter = 0;
            displayWord = "_ _ _ _ _ _ _ _";
            lblWord.Text = (displayWord);















        }

      

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int index = word.IndexOf(txtGuess.Text.ToUpper());
            if (index == -1)
            {

            }
           
        }
    }
}
