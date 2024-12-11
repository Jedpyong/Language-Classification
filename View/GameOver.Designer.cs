namespace LanguageClassificationApp.View
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.gameOverLabel = new Guna.UI.WinForms.GunaLabel();
            this.retryBttn = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.language2Label = new Guna.UI.WinForms.GunaLabel();
            this.panelLabel = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.language1Label = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.retryBttn)).BeginInit();
            this.panelLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.gameOverLabel.Location = new System.Drawing.Point(480, 281);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(317, 64);
            this.gameOverLabel.TabIndex = 5;
            this.gameOverLabel.Text = "Game Over :(";
            // 
            // retryBttn
            // 
            this.retryBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retryBttn.BaseColor = System.Drawing.Color.White;
            this.retryBttn.Image = ((System.Drawing.Image)(resources.GetObject("retryBttn.Image")));
            this.retryBttn.Location = new System.Drawing.Point(603, 201);
            this.retryBttn.Margin = new System.Windows.Forms.Padding(2);
            this.retryBttn.Name = "retryBttn";
            this.retryBttn.Size = new System.Drawing.Size(80, 78);
            this.retryBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.retryBttn.TabIndex = 6;
            this.retryBttn.TabStop = false;
            this.retryBttn.UseTransfarantBackground = false;
            this.retryBttn.Click += new System.EventHandler(this.retryBttn_Click);
            // 
            // language2Label
            // 
            this.language2Label.AutoSize = true;
            this.language2Label.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.language2Label.Location = new System.Drawing.Point(295, 11);
            this.language2Label.Name = "language2Label";
            this.language2Label.Size = new System.Drawing.Size(73, 21);
            this.language2Label.TabIndex = 7;
            this.language2Label.Text = "cebuano";
            // 
            // panelLabel
            // 
            this.panelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLabel.Controls.Add(this.gunaLabel1);
            this.panelLabel.Controls.Add(this.gunaLabel4);
            this.panelLabel.Controls.Add(this.language2Label);
            this.panelLabel.Controls.Add(this.language1Label);
            this.panelLabel.Controls.Add(this.gunaLabel2);
            this.panelLabel.Location = new System.Drawing.Point(396, 369);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(528, 46);
            this.panelLabel.TabIndex = 8;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.gunaLabel1.Location = new System.Drawing.Point(361, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(166, 21);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = ". Give it another shot!";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.gunaLabel4.Location = new System.Drawing.Point(167, 11);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(132, 21);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.Text = ", but we needed ";
            // 
            // language1Label
            // 
            this.language1Label.AutoSize = true;
            this.language1Label.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.language1Label.Location = new System.Drawing.Point(101, 11);
            this.language1Label.Name = "language1Label";
            this.language1Label.Size = new System.Drawing.Size(73, 21);
            this.language1Label.TabIndex = 9;
            this.language1Label.Text = "cebuano";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.gunaLabel2.Location = new System.Drawing.Point(3, 11);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(107, 21);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "Close! That’s ";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Variable Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.gunaLabel3.Location = new System.Drawing.Point(615, 418);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(149, 36);
            this.gunaLabel3.TabIndex = 11;
            this.gunaLabel3.Text = "Time\'s Up!";
            this.gunaLabel3.Visible = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.panelLabel);
            this.Controls.Add(this.retryBttn);
            this.Controls.Add(this.gameOverLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(1326, 709);
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.Resize += new System.EventHandler(this.GameOver_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.retryBttn)).EndInit();
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gameOverLabel;
        private Guna.UI.WinForms.GunaCirclePictureBox retryBttn;
        private Guna.UI.WinForms.GunaLabel language2Label;
        private Guna.UI.WinForms.GunaPanel panelLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel language1Label;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}
