using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace FrivDesktop
{
    public partial class frmExec : Form
    {
        // SWFs aqui https://github.com/arichornlover/FrivReborn/tree/gh-pages/games
        private string game;
        private byte[] swfBytes;
        public frmExec(string game, string title)
        {
            InitializeComponent();
            this.game = game;
            this.Text = title + " - Friv Desktop";
        }

        private void frmExec_Load(object sender, EventArgs e)
        {            
            axShockwaveFlash1.AllowFullScreen = "true";
            axShockwaveFlash1.AllowScriptAccess = "always";

            switch (game)
            {
                case "FormulaRacer2012":
                    // Obtendo os bytes do arquivo SWF a partir dos recursos
                    swfBytes = Properties.Resources.FormulaRacer2012_swf;                    
                    break;  
                default:
                    MessageBox.Show("Jogo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;  
            }

            // Salvando o arquivo SWF em um diretório temporário
            string caminhoTemporario = Path.Combine(Path.GetTempPath(), "_temp.swf");
            File.WriteAllBytes(caminhoTemporario, swfBytes);

            //webBrowserPrincipal.Navigate(caminhoTemporario);

            axShockwaveFlash1.Movie = caminhoTemporario;
            axShockwaveFlash1.Play();
        }

        private void frmExec_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string caminhoSWF = Path.Combine(Path.GetTempPath(), "_temp.swf");

                if (File.Exists(caminhoSWF))
                {
                    File.Delete(caminhoSWF); // Remove o arquivo temporário
                }

                axShockwaveFlash1.Rewind();
                axShockwaveFlash1.Stop();
                //MessageBox.Show("Arquivo excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao limpar arquivo temporário: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
