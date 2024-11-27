namespace LanguageClassificationApp
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanelTop = new Guna.UI.WinForms.GunaPanel();
            this.exitBttn = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.placeholder_panel = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 741);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1578, 80);
            this.gunaPanel1.TabIndex = 1;
            // 
            // gunaPanelTop
            // 
            this.gunaPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.gunaPanelTop.Controls.Add(this.exitBttn);
            this.gunaPanelTop.Controls.Add(this.gunaLabel1);
            this.gunaPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanelTop.Location = new System.Drawing.Point(0, 0);
            this.gunaPanelTop.Name = "gunaPanelTop";
            this.gunaPanelTop.Size = new System.Drawing.Size(1578, 80);
            this.gunaPanelTop.TabIndex = 0;
            // 
            // exitBttn
            // 
            this.exitBttn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBttn.Image = ((System.Drawing.Image)(resources.GetObject("exitBttn.Image")));
            this.exitBttn.ImageSize = new System.Drawing.Size(40, 40);
            this.exitBttn.Location = new System.Drawing.Point(1501, 0);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.OnHoverImage = null;
            this.exitBttn.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.exitBttn.Size = new System.Drawing.Size(77, 80);
            this.exitBttn.TabIndex = 0;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.gunaLabel1.Location = new System.Drawing.Point(39, 20);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(204, 41);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "VersaTula";
            // 
            // placeholder_panel
            // 
            this.placeholder_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeholder_panel.Location = new System.Drawing.Point(0, 80);
            this.placeholder_panel.Name = "placeholder_panel";
            this.placeholder_panel.Size = new System.Drawing.Size(1578, 661);
            this.placeholder_panel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 821);
            this.Controls.Add(this.placeholder_panel);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaPanelTop.ResumeLayout(false);
            this.gunaPanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanelTop;
        private Guna.UI.WinForms.GunaPanel placeholder_panel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaImageButton exitBttn;
    }
}