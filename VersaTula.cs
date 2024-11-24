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
    public partial class VersaTula : Form
    {
        public VersaTula()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = input.Text; // Get text from TextBox
                LanguagePredictor detector = new LanguagePredictor();
                string language = await detector.DetectLanguageAsync(inputText);

                output.Text = $"Detected Language: {language}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
