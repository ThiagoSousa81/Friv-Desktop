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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExec));
            //this.webBrowserPrincipal = new System.Windows.Forms.WebBrowser();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            /*// 
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
            this.webBrowserPrincipal.Visible = false;
            this.webBrowserPrincipal.WebBrowserShortcutsEnabled = false;*/
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(14, 12);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill;            
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(600, 500);
            this.axShockwaveFlash1.TabIndex = 5;
            // 
            // frmExec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   
            //this.Controls.Add(this.webBrowserPrincipal);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Name = "frmExec";
            this.Text = "Game Title - Friv Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExec_FormClosing);
            this.Load += new System.EventHandler(this.frmExec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);            
        }

        #endregion

        //private System.Windows.Forms.WebBrowser webBrowserPrincipal;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
    }
}