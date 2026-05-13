using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            pessoa p = new pessoa();
            p.nome = txbNome.Text;
            p.cidade = txbCidade.Text;

            bool retorno = p.gravar();
            if (retorno == true)
            {
                MessageBox.Show("Gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao gravar!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            banco bd= new banco();
            string sql = "select * from pessoas";
            DataTable dt = new DataTable();

            dt= bd.executarConsultaGenerica(sql);


            dataGridView1.DataSource = dt;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pessoa p = new pessoa();
            int id = int.Parse(txbId.Text);
            p.consultar(id);
            MessageBox.Show(p.nome);


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pessoa p= new pessoa();
            p.id= int.Parse(txbId.Text);

            bool retorno = p.excluir();

            if (retorno == true)
            {
                MessageBox.Show(p.nome + "foi excluido!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir ou pessoa não encontrada.");
            }
        }

        private void btConsultarEdicao_Click(object sender, EventArgs e)
        {
            pessoa p = new pessoa();
            int id = int.Parse(txbIdEdicao.Text);
            p.consultar(id);    
            txbNomeEdicao.Text = p.nome;
            txbCidadeEdicao.Text = p.cidade;   
            txbIdEdicao.Enabled=false;
        }

        private void btGravarEdicao_Click(object sender, EventArgs e)
        {
            pessoa p = new pessoa();
            p.id = int.Parse(txbIdEdicao.Text);
            p.nome = txbNomeEdicao.Text;
            p.cidade = txbCidadeEdicao.Text;

            bool retorno = p.atualizar();
            if (retorno)
            {
                MessageBox.Show("Pessoa atualizada com sucesso!");

            }
            else
            {
                MessageBox.Show("Erro ao atualizar pessoa.");
            }
            txbIdEdicao.Enabled = true;
            txbCidadeEdicao.Text = "";
            txbNomeEdicao.Text = "";
        }
    }
}
