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
            this.inputTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.languageLabel = new Guna.UI.WinForms.GunaLabel();
            this.submitBttn = new Guna.UI.WinForms.GunaButton();
            this.helpBttn = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.BaseColor = System.Drawing.Color.White;
            this.inputTextBox.BorderColor = System.Drawing.Color.Silver;
            this.inputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.inputTextBox.FocusedBorderColor = System.Drawing.Color.White;
            this.inputTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(425, 153);
            this.inputTextBox.MultiLine = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.PasswordChar = '\0';
            this.inputTextBox.Radius = 20;
            this.inputTextBox.Size = new System.Drawing.Size(731, 341);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "Enter your text here...";
            this.inputTextBox.Enter += new System.EventHandler(this.inputTextBox_Enter);
            this.inputTextBox.Leave += new System.EventHandler(this.inputTextBox_Leave);
            // 
            // languageLabel
            // 
            this.languageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.languageLabel.Location = new System.Drawing.Point(644, 103);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(304, 38);
            this.languageLabel.TabIndex = 1;
            this.languageLabel.Text = "This round is Tagalog.";
            // 
            // submitBttn
            // 
            this.submitBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitBttn.AnimationHoverSpeed = 0.07F;
            this.submitBttn.AnimationSpeed = 0.03F;
            this.submitBttn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.submitBttn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.submitBttn.BorderSize = 1;
            this.submitBttn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBttn.ForeColor = System.Drawing.Color.Black;
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
            this.submitBttn.Text = "Submit";
            this.submitBttn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // helpBttn
            // 
            this.helpBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBttn.AutoSize = true;
            this.helpBttn.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.helpBttn.Location = new System.Drawing.Point(1387, 13);
            this.helpBttn.Name = "helpBttn";
            this.helpBttn.Size = new System.Drawing.Size(188, 30);
            this.helpBttn.TabIndex = 3;
            this.helpBttn.Text = "How to play?";
            this.helpBttn.Click += new System.EventHandler(this.helpBttn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.helpBttn);
            this.Controls.Add(this.submitBttn);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1578, 671);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox inputTextBox;
        private Guna.UI.WinForms.GunaLabel languageLabel;
        private Guna.UI.WinForms.GunaButton submitBttn;
        private Guna.UI.WinForms.GunaLabel helpBttn;
    }
}
