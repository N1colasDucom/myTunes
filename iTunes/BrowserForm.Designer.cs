namespace iTunes
{
    partial class BrowserForm
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
            this.TxtBoxURL = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnGO = new System.Windows.Forms.Button();
            this.BtnSuivant = new System.Windows.Forms.Button();
            this.BtnPrecedent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxURL
            // 
            this.TxtBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxURL.Location = new System.Drawing.Point(150, 12);
            this.TxtBoxURL.Name = "TxtBoxURL";
            this.TxtBoxURL.Size = new System.Drawing.Size(706, 20);
            this.TxtBoxURL.TabIndex = 26;
            this.TxtBoxURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxURL_KeyPress);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 38);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(906, 404);
            this.webBrowser1.TabIndex = 27;
            this.webBrowser1.Url = new System.Uri("http://www.amazon.fr", System.UriKind.Absolute);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // BtnGO
            // 
            this.BtnGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGO.Location = new System.Drawing.Point(862, 10);
            this.BtnGO.Name = "BtnGO";
            this.BtnGO.Size = new System.Drawing.Size(56, 23);
            this.BtnGO.TabIndex = 28;
            this.BtnGO.Text = "GO";
            this.BtnGO.UseVisualStyleBackColor = true;
            // 
            // BtnSuivant
            // 
            this.BtnSuivant.Location = new System.Drawing.Point(88, 9);
            this.BtnSuivant.Name = "BtnSuivant";
            this.BtnSuivant.Size = new System.Drawing.Size(56, 23);
            this.BtnSuivant.TabIndex = 29;
            this.BtnSuivant.Text = "Suivant";
            this.BtnSuivant.UseVisualStyleBackColor = true;
            this.BtnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // BtnPrecedent
            // 
            this.BtnPrecedent.Location = new System.Drawing.Point(12, 9);
            this.BtnPrecedent.Name = "BtnPrecedent";
            this.BtnPrecedent.Size = new System.Drawing.Size(70, 23);
            this.BtnPrecedent.TabIndex = 30;
            this.BtnPrecedent.Text = "Precedent";
            this.BtnPrecedent.UseVisualStyleBackColor = true;
            this.BtnPrecedent.Click += new System.EventHandler(this.BtnPrecedent_Click);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 454);
            this.Controls.Add(this.BtnPrecedent);
            this.Controls.Add(this.BtnSuivant);
            this.Controls.Add(this.BtnGO);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.TxtBoxURL);
            this.Name = "BrowserForm";
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxURL;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BtnGO;
        private System.Windows.Forms.Button BtnSuivant;
        private System.Windows.Forms.Button BtnPrecedent;
    }
}