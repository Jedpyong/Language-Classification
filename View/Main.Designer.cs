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
            this.inputTextBox.Location = new System.Drawing.Point(425, 153);
            this.inputTextBox.MultiLine = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Padding = new System.Windows.Forms.Padding(10);
            this.inputTextBox.PasswordChar = '\0';
            this.inputTextBox.Radius = 20;
            this.inputTextBox.Size = new System.Drawing.Size(731, 341);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "Enter your text here...";
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            this.inputTextBox.Enter += new System.EventHandler(this.inputTextBox_Enter);
            this.inputTextBox.Leave += new System.EventHandler(this.inputTextBox_Leave);
            // 
            // languageLabel
            // 
            this.languageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.languageLabel.Location = new System.Drawing.Point(3, 10);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(338, 36);
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
            this.submitBttn.Location = new System.Drawing.Point(687, 568);
            this.submitBttn.Name = "submitBttn";
            this.submitBttn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.submitBttn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.submitBttn.OnHoverForeColor = System.Drawing.Color.White;
            this.submitBttn.OnHoverImage = null;
            this.submitBttn.OnPressedColor = System.Drawing.Color.Tan;
            this.submitBttn.Radius = 10;
            this.submitBttn.Size = new System.Drawing.Size(215, 71);
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
            this.helpBttn.Location = new System.Drawing.Point(1382, 13);
            this.helpBttn.Name = "helpBttn";
            this.helpBttn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.helpBttn.Size = new System.Drawing.Size(193, 30);
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
            this.gameLabels.Location = new System.Drawing.Point(442, 92);
            this.gameLabels.Name = "gameLabels";
            this.gameLabels.Size = new System.Drawing.Size(714, 55);
            this.gameLabels.TabIndex = 4;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.timerLabel.Location = new System.Drawing.Point(594, 5);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(117, 41);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "00:00";
            // 
            // placeholder_language
            // 
            this.placeholder_language.AutoSize = true;
            this.placeholder_language.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder_language.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.placeholder_language.Location = new System.Drawing.Point(303, 4);
            this.placeholder_language.Name = "placeholder_language";
            this.placeholder_language.Size = new System.Drawing.Size(0, 41);
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
            this.gunaLabel1.Location = new System.Drawing.Point(3, 10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(190, 46);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "ROUND ";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.Controls.Add(this.roundNum);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(702, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(268, 62);
            this.gunaPanel1.TabIndex = 6;
            // 
            // roundNum
            // 
            this.roundNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roundNum.AutoSize = true;
            this.roundNum.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.roundNum.Location = new System.Drawing.Point(199, 7);
            this.roundNum.Name = "roundNum";
            this.roundNum.Size = new System.Drawing.Size(44, 46);
            this.roundNum.TabIndex = 6;
            this.roundNum.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gameLabels);
            this.Controls.Add(this.helpBttn);
            this.Controls.Add(this.submitBttn);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1578, 671);
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
    }
}
