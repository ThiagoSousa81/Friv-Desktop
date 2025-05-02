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
        //private string game;
        private string game;
        private byte[] swfBytes;
        public frmExec(/*string game,*/ string game)
        {
            InitializeComponent();
            //this.game = game;
            this.Text = game + " - Friv Desktop";
            this.game = game;
        }

        private void frmExec_Load(object sender, EventArgs e)
        {            
            axShockwaveFlash1.AllowFullScreen = "true";
            axShockwaveFlash1.AllowScriptAccess = "always";

            switch (game)
            {
                case "Formula Racer 2012":
                    // Obtendo os bytes do arquivo SWF a partir dos recursos
                    swfBytes = Properties.Resources.formula_racer_2012;
                    break;
                case "TU-95":
                    swfBytes = Properties.Resources.tu_95;
                    break;
                case "Aagrh":
                    swfBytes = Properties.Resources.aargh;
                    break;
                case "Tractor Mania":
                    swfBytes = Properties.Resources.tractor_mania;
                    break;
                case "Car Eat's Car 2 - Deluxe":
                    swfBytes = Properties.Resources.car_eats_car_2_deluxe;
                    break;
                case "Ace Gangster":
                    swfBytes = Properties.Resources.ace_gangster;
                    break;
                case "Ace Gangster Taxi":
                    swfBytes = Properties.Resources.ace_gangster_taxi;
                    break;
                case "Alien Attack Team":
                    swfBytes = Properties.Resources.alien_attack_team;
                    break;
                case "Bridge Tactics":
                    swfBytes = Properties.Resources.bridge_tactics;
                    break;
                case "Bridge Tatics 2":
                    swfBytes = Properties.Resources.bridge_tactics_2;
                    break;
                case "Car Eat's Car 3 - Twisted Dreams":
                    swfBytes = Properties.Resources.car_eats_car_3_twisted_dreams;
                    break;
                case "Civiballs":
                    swfBytes = Properties.Resources.civiballs;
                    break;
                case "Dynamite Train":
                    swfBytes = Properties.Resources.dynamite_train;
                    break;
                case "Feed Us 4":
                    swfBytes = Properties.Resources.feed_us_4;
                    break;
                case "Feed Us 4 - Xmas":
                    swfBytes = Properties.Resources.feed_us_4_xmas_xpend;
                    break;
                case "Fever For Speed":
                    swfBytes = Properties.Resources.feverforspeed;
                    break;
                case "Freeway Fury 2":
                    swfBytes = Properties.Resources.freeway_fury_2;
                    break;
                case "Bloxorz":
                    swfBytes = Properties.Resources.flash_bloxorz;
                    break;
                case "Haunt The House":
                    swfBytes = Properties.Resources.haunt_the_house;
                    break;
                case "Jack Smith":
                    swfBytes = Properties.Resources.jacksmith;
                    break;
                case "King's Rush":
                    swfBytes = Properties.Resources.kings_rush;
                    break;
                case "Mega Miner":
                    swfBytes = Properties.Resources.mega_miner;
                    break;
                case "Scrap Metal Heroes":
                    swfBytes = Properties.Resources.scrap_metal_heroes;
                    break;
                case "Sky Serpents":
                    swfBytes = Properties.Resources.skyserpents;
                    break;
                case "Stunt Master":
                    swfBytes = Properties.Resources.stunt_master;
                    break;
                case "The Heist":
                    swfBytes = Properties.Resources.the_heist;
                    break;
                case "Urban Unrest":
                    swfBytes = Properties.Resources.urban_unrest;
                    break;
                case "Zombotron":
                    swfBytes = Properties.Resources.zombotron;
                    break;
                case "Zombotron 2":
                    swfBytes = Properties.Resources.zombotron2;
                    break;
                case "Zombotron 2 - Time Machine":
                    swfBytes = Properties.Resources.zombotron2_time_machine;
                    break;
                default:
                    MessageBox.Show("Jogo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return; // Evita continuar com o código                            
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
