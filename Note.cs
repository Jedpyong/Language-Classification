using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageClassificationApp
{
    public class Note
    {
        private List<string> phrases = new List<string>();

        public Note()
        {
            // Initialize the list to ensure it's never null
            phrases = new List<string>();
        }

        // Add a new phrase to the list
        public void AddPhrase(string line)
        {
            phrases.Add(line);
        }

        // Append all phrases together into a single string, each on a new line
        public string AppendPhrase()
        {
            return string.Join(Environment.NewLine, phrases);
        }

        // Get all phrases as a list
        public List<string> GetPhrases()
        {
            return phrases;
        }
    }
}
