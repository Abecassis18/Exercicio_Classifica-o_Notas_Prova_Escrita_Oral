using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Classificação_Notas_Prova_Escrita_Oral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
            limparControlos();

            ntfMy.Visible = true;
            ntfMy.BalloonTipText = "Programa em execução.";
            ntfMy.ShowBalloonTip(6000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(object objeto in this.Controls)
            {
                if(objeto is ComboBox)
                {
                    for (int cont = 0; cont <= 20; cont++)
                    {
                        ((ComboBox)objeto).Items.Add(cont);
                    }
                 }
            }
        }

        private void limparControlos()
        {
            txtNome.ResetText();
            cboEscrita.Text = "10";
            cboOral.Text = "10";
            cboFisica.Text = "10";

            chkIngles.Checked = false;
            chkAlemao.Checked = false;
            chkEspanhol.Checked = false;
            chkFrances.Checked = false;
            chkPortugues.Checked = false;
            chkRusso.Checked = false;
        }

        public int verificarCheks()
        {
            int checksMarcados = 0;
          
            foreach(object objeto in grbLinguas.Controls)
            {
                if(objeto is CheckBox)
                {
                    if(((CheckBox)objeto).Checked == true)
                    {
                       checksMarcados ++;
                    }
                }
            }

            return checksMarcados;
        }

        private string resultadoAdmissao(int verificadorLinguas, int escrita, int oral, int fisica)
        {
            string resultado = "";
            double mediaProvas = 0;

            mediaProvas = (escrita + oral + fisica) / 3;

            if (mediaProvas >= 10 && verificadorLinguas >= 2) resultado = "Admitido";
            else resultado = "Não admitido";
            
            return resultado;
         }

        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            string resultado ="" ;

            if (txtNome.Text != "")
            {
                resultado = resultadoAdmissao(verificarCheks(), int.Parse(cboEscrita.Text), int.Parse(cboOral.Text), int.Parse(cboFisica.Text)).ToString();

                dgvGrelha.Rows.Add(txtNome.Text, cboEscrita.Text, cboOral.Text, cboFisica.Text, verificarCheks(), resultado);

                limparControlos();
            }
            else MessageBox.Show("Preencha o campo nome.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNome.Focus();
        }
    }
}
