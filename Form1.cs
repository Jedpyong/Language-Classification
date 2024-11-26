using LanguageClassificationApp.View;
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
    public partial class Form1 : Form
    {
        private Main mainControl;
        public Form1()
        {
            InitializeComponent();
            mainControl = new Main();
            mainControl.Dock = DockStyle.Fill;
            this.Controls.Add(mainControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Main myControl = new Main(); // Instantiate the UserControl
            myControl.Dock = DockStyle.Fill; // Optional: Dock it to fill the Panel
            placeholder_panel.Controls.Add(myControl); // Add the UserControl to the Panel

        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Exit the application
                Application.Exit();
            }
        }
    }
}
