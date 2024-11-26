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
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }

        private void inputTextBox_Enter(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "Enter your text here...")
            {
                inputTextBox.Text = "";
            }
        }

        private void inputTextBox_Leave(object sender, EventArgs e)
        {
            if(inputTextBox.Text == "")
            {
                inputTextBox.Text = "Enter your text here...";
            }
        }

        private void helpBttn_Click(object sender, EventArgs e)
        {
            Help myControl = new Help(); 
            myControl.Dock = DockStyle.Fill;
            this.Controls.Add(myControl);
           
        }
    }
}
