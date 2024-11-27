using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageClassificationApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Resize += new EventHandler(MainMenu_Resize);
            MainMenu_Resize(null, null);

        }

        private void MainMenu_Resize(object sender, EventArgs e)
        {
            playButton.Left = (this.ClientSize.Width - playButton.Width) / 2;
            playButton.Top = (this.ClientSize.Height - playButton.Height) / 2;



            // Center the label above the button
            titleLabel.Left = (this.ClientSize.Width - titleLabel.Width) / 2;
            titleLabel.Top = playButton.Top - titleLabel.Height - 10; // Adjust spacing as needed

           

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            HomeScreen home = new HomeScreen();
            home.Show();
        }
    }
}
