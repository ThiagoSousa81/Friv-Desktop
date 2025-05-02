using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Security.Policy;

namespace FrivDesktop
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }    

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string game = cboGame.Text;
            frmExec exec = new frmExec(game);
            exec.ShowDialog();            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/ThiagoSousa81/Friv-Desktop",
                UseShellExecute = true // Necessário para abrir URLs no navegador padrão
            });
        }
    }
}
