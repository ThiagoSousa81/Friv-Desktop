using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

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
    }
}
