using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageClassificationApp.View
{
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();
        }
        
        private void retryBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GameOver_Resize(object sender, EventArgs e)
        {
            retryBttn.Left = (this.ClientSize.Width - retryBttn.Width) / 2;
            retryBttn.Top = retryBttn.Top - retryBttn.Height - 10;

            gameOverLabel.Left = (this.ClientSize.Width - gameOverLabel.Width) / 2;
            gameOverLabel.Top = (this.ClientSize.Height - gameOverLabel.Height) / 2;

            
        }
    }
}
