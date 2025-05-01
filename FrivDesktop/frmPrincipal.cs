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

            switch (game)
            {
                case "Fórmula Racer 2012":
                    frmExec exec = new frmExec("FormulaRacer2012", "Fórmula Racer 2012");
                    exec.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Selecione um game para continuar!", "Friv Desktop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
