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
            ((System.ComponentModel.ISupportInitialize)(this.retryBttn)).BeginInit();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.gameOverLabel.Location = new System.Drawing.Point(458, 182);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(691, 82);
            this.gameOverLabel.TabIndex = 5;
            this.gameOverLabel.Text = "Game Over :((((((";
            // 
            // retryBttn
            // 
            this.retryBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retryBttn.BaseColor = System.Drawing.Color.White;
            this.retryBttn.Image = ((System.Drawing.Image)(resources.GetObject("retryBttn.Image")));
            this.retryBttn.Location = new System.Drawing.Point(717, 367);
            this.retryBttn.Name = "retryBttn";
            this.retryBttn.Size = new System.Drawing.Size(120, 120);
            this.retryBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.retryBttn.TabIndex = 6;
            this.retryBttn.TabStop = false;
            this.retryBttn.UseTransfarantBackground = false;
            this.retryBttn.Click += new System.EventHandler(this.retryBttn_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.retryBttn);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(1578, 671);
            this.Resize += new System.EventHandler(this.GameOver_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.retryBttn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gameOverLabel;
        private Guna.UI.WinForms.GunaCirclePictureBox retryBttn;
    }
}
