    using Guna.UI.Animation;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;


    namespace LanguageClassificationApp.View
    {
        public partial class Main : UserControl
        {
            private int timeLeft;
            private string language;
            private int round;
            public string poemLine;
            public Note note;
            public string target;
            
            public Main()
            {
                InitializeComponent();
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += timer_Tick;
                round = 1;
                submitBttn.Enabled = !string.IsNullOrWhiteSpace(inputTextBox.Text);
                Submit.Visible = false;
                Submit.Enabled = false;


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
                myControl.BringToFront();
           
            }

            private void timer_Tick(object sender, EventArgs e)
            {
                if (timeLeft > 0)
                {
                    timeLeft--;
                    timerLabel.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");
            }
                else
                {
                    timer.Stop();
                    GameOver gameOver = new GameOver();
                    gameOver.Dock = DockStyle.Fill;
                    this.Controls.Add(gameOver);
                    gameOver.BringToFront();
                }
            }

            private void submitBttn_Click(object sender, EventArgs e)
            {
             // the problem is that onl thefourth round was printed on the victory page, and after you succeed  you cant proceed to the gam,since the start button was disabled
                inputTextBox.Enabled = true;
            if (inputTextBox.Text == "Enter your text here...")
            {
                inputTextBox.Text = "";
            }

            // Randomizing language requirement
            placeholder_language.Text = randomLanguage();
                target = placeholder_language.Text.ToLower();
                  // Start a new round with the timer running
                timeLeft = 30; 
                timerLabel.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");
                timer.Start();
                roundNum.Text = round.ToString();
                submitBttn.Enabled = false;
                submitBttn.Visible = false;
                Submit.Visible = true;
                Submit.Enabled = true;
                    // Append the last phrase to the Note    
                    // Note note = new Note();
                    // note.AddPhrase(inputTextBox.Text);
                    //poemLine = note.AppendPhrase();
            }

            private string randomLanguage()
            {
                Random random = new Random();
                string[] languages = { "TAGALOG", "ENGLISH", "CEBUANO" };
                return languages[random.Next(languages.Length)];
            }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputTextBox.Text))
            {
                submitBttn.Enabled = false;
            }
            else
            {
                submitBttn.Enabled = true;
            }
        }

        private void inputTextBox_Click(object sender, EventArgs e)
        {

        }

        private async void Submit_Click(object sender, EventArgs e)
        {
            bool isWrong = false;
            Submit.Enabled = false;
                if (round <= 2)
                {
                    inputTextBox.Enabled = true;
                    timer.Stop();
                    LanguagePredictor predictor = new LanguagePredictor();
                if (inputTextBox.Text.Length > 0)
                    {

                        string input = inputTextBox.Text;
                        string language = (await predictor.DetectLanguageAsync(input)).ToLower();
                        MessageBox.Show(target, language);
                        if (string.Equals(language, target))
                        {
                            //note.AddPhrase(input);
                            poemLine += input + '\n';
                            if (round % 4 == 0)
                                poemLine += '\n';
                            // MessageBox.Show("Good Job!");

                        }
                        if (!(string.Equals(language, target)))
                        {
                            MessageBox.Show("Wronging");
                            GameOver gameOver = new GameOver();
                            gameOver.Dock = DockStyle.Fill;
                            this.Controls.Add(gameOver);
                            gameOver.BringToFront();
                            isWrong = true;
                            round--;
                        }
                        // Randomizing language requirement
                        placeholder_language.Text = randomLanguage();
                        target = placeholder_language.Text.ToLower();
                        round++;
                        inputTextBox.Text = "";
                        timeLeft = 30;
                        timerLabel.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");
                        timer.Start();
                        roundNum.Text = round.ToString();

                    }
                }


                if (round > 2 && !isWrong)
                {
                    roundNum.Text = "0";
                    placeholder_language.Text = "";
                    inputTextBox.Text = "Enter your text here...";
                    inputTextBox.Enabled = false;

                // Pass the poemLine to the Victory form to display it
                    Victory complete = new Victory();
                    complete.Dock = DockStyle.Fill;
                    this.Controls.Add(complete);
                    complete.BringToFront();

                // Set the poem (or note) as a property of the Victory form
                    complete.SetPoem(poemLine);

                // Reset round count and the timer
                    poemLine.Remove(0);
                    round = 1;
                    timer.Stop();
                    timeLeft = 0;
                    timerLabel.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");

                    submitBttn.Visible = true;
                    submitBttn.Enabled = true;
                    Submit.Visible = false;
                    Submit.Enabled = false;
                }
               
            Submit.Enabled = true;
        }

           

    }
    }
