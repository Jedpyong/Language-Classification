namespace LanguageClassificationApp.View
{
    partial class Victory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Victory));
            this.placeholder_poem = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.backBttn = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backBttn)).BeginInit();
            this.SuspendLayout();
            // 
            // placeholder_poem
            // 
            this.placeholder_poem.AutoSize = true;
            this.placeholder_poem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder_poem.Location = new System.Drawing.Point(171, 81);
            this.placeholder_poem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placeholder_poem.Name = "placeholder_poem";
            this.placeholder_poem.Size = new System.Drawing.Size(726, 150);
            this.placeholder_poem.TabIndex = 9;
            this.placeholder_poem.Text = resources.GetString("placeholder_poem.Text");
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.gunaLabel3.Location = new System.Drawing.Point(397, 40);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(205, 31);
            this.gunaLabel3.TabIndex = 11;
            this.gunaLabel3.Text = "Congratulations";
            // 
            // backBttn
            // 
            this.backBttn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backBttn.BaseColor = System.Drawing.Color.White;
            this.backBttn.Image = ((System.Drawing.Image)(resources.GetObject("backBttn.Image")));
            this.backBttn.Location = new System.Drawing.Point(7, 6);
            this.backBttn.Margin = new System.Windows.Forms.Padding(2);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(40, 39);
            this.backBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backBttn.TabIndex = 12;
            this.backBttn.TabStop = false;
            this.backBttn.UseTransfarantBackground = false;
            this.backBttn.Click += new System.EventHandler(this.backBttn_Click);
            // 
            // Victory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backBttn);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.placeholder_poem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Victory";
            this.Size = new System.Drawing.Size(1052, 436);
            ((System.ComponentModel.ISupportInitialize)(this.backBttn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel placeholder_poem;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaCirclePictureBox backBttn;
    }
}
