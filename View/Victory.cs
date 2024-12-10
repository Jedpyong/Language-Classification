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
    public partial class Victory : UserControl
    {
        public Victory()
        {
            InitializeComponent();
            this.Resize += Victory_Resize; 
            Victory_Resize(this, EventArgs.Empty);
        }

        public void SetPoem(string poem)
        {
            // Assuming you have a Label called finalPoemLabel to display the poem
            placeholder_poem.Text = poem;
        }

        private void backBttn_Click(object sender, EventArgs e)
        {
            HomeScreen home = new HomeScreen();
            home.Show();
            this.Hide();
        }

        private void Victory_Resize(object sender, EventArgs e)
        {
            placeholder_poem.Left = (this.ClientSize.Width - placeholder_poem.Width) / 2;
            placeholder_poem.Top = (this.ClientSize.Height - placeholder_poem.Height) / 2 - 50;
            
            backBttn.Left = 10;
            backBttn.Top = 10;
        }
    }
}