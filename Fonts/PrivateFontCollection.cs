using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;

namespace LanguageClassificationApp.Fonts
{
    public class FontManager
    {

        private List<string> fontPaths = new List<string>
        {
            @"Fonts\Montserrat-ExtraBold.ttf",
            @"Fonts\Modak-Regular.ttf"        
        };

        PrivateFontCollection privateFonts = new PrivateFontCollection();

        // Function to set font dynamically
        private void setFont(int fontIndex, Control control, float fontSize)
        {
            if (fontIndex < 0 || fontIndex >= fontPaths.Count)
            {
                MessageBox.Show("Invalid font index.");
                return;
            }

            string fontPath = fontPaths[fontIndex];

            try
            {
                privateFonts.AddFontFile(fontPath);
                Font customFont = new Font(privateFonts.Families[privateFonts.Families.Length - 1], fontSize);

                // Apply the font to the specified control
                control.Font = customFont;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load font: {ex.Message}");
            }
        }


        
    }
}
