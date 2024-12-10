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
            this.Resize += GameOver_Resize; // Ensure the Resize event is hooked up
            GameOver_Resize(this, EventArgs.Empty);// Call the resize method to position controls
        }

        public void setLanguageDetected(string value)
        {
            language2Label.Text = value;
        }

        public void setLanguageRequired(string value)
        {
            language1Label.Text = value;
        }

        private void retryBttn_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        

        private void GameOver_Resize(object sender, EventArgs e)
        {
            gameOverLabel.Left = (this.ClientSize.Width - gameOverLabel.Width) / 2;
            gameOverLabel.Top = (this.ClientSize.Height - gameOverLabel.Height) / 2;

            retryBttn.Left = (this.ClientSize.Width - retryBttn.Width) / 2;
            retryBttn.Top = gameOverLabel.Top - retryBttn.Height - 10;

            panelLabel.Left = (this.ClientSize.Width - panelLabel.Width) / 2;
            panelLabel.Top = gameOverLabel.Top + gameOverLabel.Height + 10;
        }
    }
}
