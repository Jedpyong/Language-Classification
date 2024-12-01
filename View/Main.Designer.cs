namespace LanguageClassificationApp.View
{
    partial class Main
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.languageLabel = new Guna.UI.WinForms.GunaLabel();
            this.submitBttn = new Guna.UI.WinForms.GunaButton();
            this.helpBttn = new Guna.UI.WinForms.GunaLabel();
            this.gameLabels = new Guna.UI.WinForms.GunaPanel();
            this.timerLabel = new Guna.UI.WinForms.GunaLabel();
            this.placeholder_language = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.roundNum = new Guna.UI.WinForms.GunaLabel();
            this.Submit = new Guna.UI.WinForms.GunaButton();
            this.gameLabels.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.BaseColor = System.Drawing.Color.White;
            this.inputTextBox.BorderColor = System.Drawing.Color.Silver;
            this.inputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTextBox.Enabled = false;
            this.inputTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.inputTextBox.FocusedBorderColor = System.Drawing.Color.White;
            this.inputTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.inputTextBox.Location = new System.Drawing.Point(283, 99);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputTextBox.MultiLine = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.inputTextBox.PasswordChar = '\0';
            this.inputTextBox.Radius = 20;
            this.inputTextBox.Size = new System.Drawing.Size(487, 335);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "Enter your text here...";
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            this.inputTextBox.Click += new System.EventHandler(this.inputTextBox_Click);
            this.inputTextBox.Enter += new System.EventHandler(this.inputTextBox_Enter);
            this.inputTextBox.Leave += new System.EventHandler(this.inputTextBox_Leave);
            // 
            // languageLabel
            // 
            this.languageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.languageLabel.Location = new System.Drawing.Point(2, 6);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(235, 25);
            this.languageLabel.TabIndex = 1;
            this.languageLabel.Text = "Language Required:";
            // 
            // submitBttn
            // 
            this.submitBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitBttn.AnimationHoverSpeed = 0.07F;
            this.submitBttn.AnimationSpeed = 0.03F;
            this.submitBttn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.submitBttn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.submitBttn.BorderSize = 1;
            this.submitBttn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.submitBttn.Image = null;
            this.submitBttn.ImageSize = new System.Drawing.Size(20, 20);
            this.submitBttn.Location = new System.Drawing.Point(458, 369);
            this.submitBttn.Margin = new System.Windows.Forms.Padding(2);
            this.submitBttn.Name = "submitBttn";
            this.submitBttn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.submitBttn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.submitBttn.OnHoverForeColor = System.Drawing.Color.White;
            this.submitBttn.OnHoverImage = null;
            this.submitBttn.OnPressedColor = System.Drawing.Color.Tan;
            this.submitBttn.Radius = 10;
            this.submitBttn.Size = new System.Drawing.Size(143, 46);
            this.submitBttn.TabIndex = 2;
            this.submitBttn.Text = "Start";
            this.submitBttn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.submitBttn.Click += new System.EventHandler(this.submitBttn_Click);
            // 
            // helpBttn
            // 
            this.helpBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBttn.AutoSize = true;
            this.helpBttn.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.helpBttn.Location = new System.Drawing.Point(921, 8);
            this.helpBttn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helpBttn.Name = "helpBttn";
            this.helpBttn.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.helpBttn.Size = new System.Drawing.Size(134, 21);
            this.helpBttn.TabIndex = 3;
            this.helpBttn.Text = "How to play?";
            this.helpBttn.Click += new System.EventHandler(this.helpBttn_Click);
            // 
            // gameLabels
            // 
            this.gameLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gameLabels.Controls.Add(this.timerLabel);
            this.gameLabels.Controls.Add(this.placeholder_language);
            this.gameLabels.Controls.Add(this.languageLabel);
            this.gameLabels.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabels.Location = new System.Drawing.Point(295, 60);
            this.gameLabels.Margin = new System.Windows.Forms.Padding(2);
            this.gameLabels.Name = "gameLabels";
            this.gameLabels.Size = new System.Drawing.Size(476, 36);
            this.gameLabels.TabIndex = 4;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.timerLabel.Location = new System.Drawing.Point(396, 3);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(75, 27);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "00:00";
            // 
            // placeholder_language
            // 
            this.placeholder_language.AutoSize = true;
            this.placeholder_language.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder_language.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.placeholder_language.Location = new System.Drawing.Point(202, 3);
            this.placeholder_language.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placeholder_language.Name = "placeholder_language";
            this.placeholder_language.Size = new System.Drawing.Size(0, 27);
            this.placeholder_language.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.gunaLabel1.Location = new System.Drawing.Point(2, 6);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(129, 31);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "ROUND ";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.Controls.Add(this.roundNum);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(468, 2);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(179, 40);
            this.gunaPanel1.TabIndex = 6;
            // 
            // roundNum
            // 
            this.roundNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roundNum.AutoSize = true;
            this.roundNum.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.roundNum.Location = new System.Drawing.Point(133, 5);
            this.roundNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roundNum.Name = "roundNum";
            this.roundNum.Size = new System.Drawing.Size(30, 31);
            this.roundNum.TabIndex = 6;
            this.roundNum.Text = "0";
            // 
            // Submit
            // 
            this.Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Submit.AnimationHoverSpeed = 0.07F;
            this.Submit.AnimationSpeed = 0.03F;
            this.Submit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.Submit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.Submit.BorderSize = 1;
            this.Submit.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.Submit.Image = null;
            this.Submit.ImageSize = new System.Drawing.Size(20, 20);
            this.Submit.Location = new System.Drawing.Point(458, 369);
            this.Submit.Margin = new System.Windows.Forms.Padding(2);
            this.Submit.Name = "Submit";
            this.Submit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.Submit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.Submit.OnHoverForeColor = System.Drawing.Color.White;
            this.Submit.OnHoverImage = null;
            this.Submit.OnPressedColor = System.Drawing.Color.Tan;
            this.Submit.Radius = 10;
            this.Submit.Size = new System.Drawing.Size(143, 46);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gameLabels);
            this.Controls.Add(this.helpBttn);
            this.Controls.Add(this.submitBttn);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1052, 436);
            this.gameLabels.ResumeLayout(false);
            this.gameLabels.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox inputTextBox;
        private Guna.UI.WinForms.GunaLabel languageLabel;
        private Guna.UI.WinForms.GunaButton submitBttn;
        private Guna.UI.WinForms.GunaLabel helpBttn;
        private Guna.UI.WinForms.GunaPanel gameLabels;
        private System.Windows.Forms.Label placeholder_language;
        private System.Windows.Forms.Timer timer;
        private Guna.UI.WinForms.GunaLabel timerLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel roundNum;
        private Guna.UI.WinForms.GunaButton Submit;
    }
}
