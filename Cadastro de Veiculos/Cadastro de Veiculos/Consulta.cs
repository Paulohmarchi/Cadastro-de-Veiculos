using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro_de_Veiculos
{
    public partial class Consulta : Form
    {
        MySqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados 
        MySqlCommandBuilder cmd; //este carinha é quem monta os codigos SQL do MySQL para enviar para o banco
        DataTable datb; //datatable é quem vai receber os dados do adpter
        MySqlConnection con; //conexao com o banco

        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
            con = new MySqlConnection("Server = localhost; user id = root; database = bdVeiculos; password = ''");
            dados = new MySqlDataAdapter("select * from veiculos", con);//classe que armazena dados
            datb = new DataTable(); //preenche data table
            dados.Fill(datb);   // transfere os pensamentos da base para o DataTable

            dgvConsulta.DataSource = datb;

            dgvConsulta.Refresh();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlCommand excluir = new MySqlCommand();
            if (dgvConsulta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão!");
                return;
            }
            else
            {
                MessageBox.Show("Tem certeza que deseja excluir esse cadastro?", "Avançar");
            }

            DataGridViewRow row = dgvConsulta.SelectedRows[0];
            dgvConsulta.Rows.RemoveAt(row.Index);

            cmd = new MySqlCommandBuilder(dados);
            dados.Update(datb);
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server = localhost; user id = root; database = bdVeiculos; password = ''");
            dados = new MySqlDataAdapter("select * from veiculos", con);
            datb = new DataTable();
            dados.Fill(datb);

            dgvConsulta.DataSource = datb;
            dgvConsulta.Refresh();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server = localhost; user id = root; database = bdVeiculos; password = ''");
            dados = new MySqlDataAdapter("select * from veiculos where vei_Nome LIKE '%" + txtPesquisar.Text + "%'", con);
            datb = new DataTable();
            dados.Fill(datb);


            dgvConsulta.DataSource = datb;
            dgvConsulta.Refresh();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroV vemCadsV = new frmCadastroV();
            this.Hide();
            vemCadsV.ShowDialog();
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
