namespace LanguageClassificationApp
{
    partial class VersaTula
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new Guna.UI.WinForms.GunaTextBox();
            this.button = new Guna.UI.WinForms.GunaButton();
            this.output = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BaseColor = System.Drawing.Color.White;
            this.input.BorderColor = System.Drawing.Color.Silver;
            this.input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input.FocusedBaseColor = System.Drawing.Color.White;
            this.input.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.input.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.input.Location = new System.Drawing.Point(66, 151);
            this.input.Name = "input";
            this.input.PasswordChar = '\0';
            this.input.Size = new System.Drawing.Size(273, 54);
            this.input.TabIndex = 1;
            this.input.Text = "Input_Text";
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button
            // 
            this.button.AnimationHoverSpeed = 0.07F;
            this.button.AnimationSpeed = 0.03F;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.button.BorderColor = System.Drawing.Color.Black;
            this.button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Image = null;
            this.button.ImageSize = new System.Drawing.Size(20, 20);
            this.button.Location = new System.Drawing.Point(111, 246);
            this.button.Name = "button";
            this.button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button.OnHoverForeColor = System.Drawing.Color.White;
            this.button.OnHoverImage = null;
            this.button.OnPressedColor = System.Drawing.Color.Black;
            this.button.Size = new System.Drawing.Size(160, 42);
            this.button.TabIndex = 2;
            this.button.Text = "Predict";
            this.button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // output
            // 
            this.output.BaseColor = System.Drawing.Color.White;
            this.output.BorderColor = System.Drawing.Color.Silver;
            this.output.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.output.FocusedBaseColor = System.Drawing.Color.White;
            this.output.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.output.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.output.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.output.Location = new System.Drawing.Point(480, 131);
            this.output.Name = "output";
            this.output.PasswordChar = '\0';
            this.output.Size = new System.Drawing.Size(226, 74);
            this.output.TabIndex = 3;
            this.output.Text = "Language";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VersaTula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button);
            this.Controls.Add(this.input);
            this.Name = "VersaTula";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox input;
        private Guna.UI.WinForms.GunaButton button;
        private Guna.UI.WinForms.GunaTextBox output;
    }
}

