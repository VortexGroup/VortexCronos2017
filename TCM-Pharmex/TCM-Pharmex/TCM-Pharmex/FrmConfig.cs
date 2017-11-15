using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TCM_Pharmex
{
    public partial class FrmConfig : MetroForm
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        public void FrmConfig_Load(object sender, EventArgs e)
        {
            

            cbxTema.Items.Add("Branco e Vermelho");
            cbxIdiom.Items.Add("Português");
            cbxIdiom.Items.Add("English");
            cbxRes.Items.Add("1920x1080");
            cbxRes.Items.Add("1280x720");

            LoadTexts();  
 
        }

         void LoadTexts()
        {
            
            if (Global.fs == 0)
            {
                Traducao.tela = new string[] { "Modo Janela", "Windowed" };
            }
            else if (Global.fs == 1)
            {
                Traducao.tela = new string[] { "Tela Cheia", "Fullscreen" };
            }

            btnAjuda.Text = Traducao.ajuda[Global.idi].ToString();
            btnVersao.Text = Traducao.versao[Global.idi].ToString();
            cbxTema.Text = Traducao.tema[Global.idi].ToString();
            btnCred.Text = Traducao.cred[Global.idi].ToString();
            cbxIdiom.Text = Traducao.idiom[Global.idi].ToString();
            cbxRes.Text = Traducao.res[Global.idi].ToString();
            btnSenha.Text = Traducao.altsenha[Global.idi].ToString();
            btnTela.Text = Traducao.tela[Global.idi].ToString();
            btnAplicar.Text = Traducao.aplicar[Global.idi].ToString();
            btnVoltar.Text = Traducao.voltar[Global.idi].ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Global.Config.Hide();
        }

        private void cbxIdiom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxIdiom.SelectedIndex == 0)
            {
                Global.idi = 0;
            }
            else if (cbxIdiom.SelectedIndex == 1)
            {
                Global.idi = 1;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            LoadTexts();
        }
    }
}
