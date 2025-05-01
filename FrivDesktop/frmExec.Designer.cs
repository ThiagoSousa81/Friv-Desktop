namespace FrivDesktop
{
    partial class frmExec
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
            this.webBrowserPrincipal = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserPrincipal
            // 
            this.webBrowserPrincipal.AllowNavigation = false;
            this.webBrowserPrincipal.AllowWebBrowserDrop = false;
            this.webBrowserPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPrincipal.Location = new System.Drawing.Point(0, 0);
            this.webBrowserPrincipal.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPrincipal.Name = "webBrowserPrincipal";
            this.webBrowserPrincipal.Size = new System.Drawing.Size(800, 450);
            this.webBrowserPrincipal.TabIndex = 0;
            this.webBrowserPrincipal.WebBrowserShortcutsEnabled = false;
            // 
            // frmExec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserPrincipal);
            this.Name = "frmExec";
            this.Text = "Game Title - Friv Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExec_FormClosing);
            this.Load += new System.EventHandler(this.frmExec_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserPrincipal;
    }
}