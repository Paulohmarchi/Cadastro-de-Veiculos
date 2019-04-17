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

    public partial class frmCadastroV : Form
    {
        //conexao com o bando de dados
        const string cad = "Server = localhost; user id = root; database = bdVeiculos; password = ''";
        MySqlConnection conectar = new MySqlConnection(cad);



        string[] Fabricante = { "Alfa Romeo", "Audi", "BMW", "Cross Lander", "Citroën", "DaimlerChrysler", "Ferrari", "Fiat", "Ford", "General Motors",
                                  "Honda", "Hyundai", "Jaguar", "Kia", "Land Rover", "Mitsubishi", "Nissan", "Peugeot", "Porsche", "Renault", "Seat",
                                  "SsangYong", "Subaru", "Toyota", "Troller", "Volkswagen", "Volvo" };

        string[] estados = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS",
                               "RO", "RR", "SC", "SP", "SE", "TO" }; 
    
        public frmCadastroV()
        {
            InitializeComponent();
        }
                

        private void btnSair_Click(object sender, EventArgs e)
        {
            const string message = "Deseja Sair do Cadastro de Veiculos?";
            const string caption = "Sair.";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
               
            }
        }
          
        
        private void frmCadastroV_Load(object sender, EventArgs e)
        {
            cbFabricante.Items.AddRange(Fabricante);
            cbEstadoCar.Items.AddRange(estados);
            cbEstadoPes.Items.AddRange(estados);


                for(int ano=1900; ano<=2050 ; ano++)
                    {
                        cbAno.Items.Add(ano.ToString());

                    }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            Bitmap imagens1 = new Bitmap(openFileDialog1.FileName);
            pbDadosVeic.Image = imagens1;
            this.Validate();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pbDadosVeic.Image = null;
        }

        private void btnCarregar2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            Bitmap imagens2 = new Bitmap(openFileDialog1.FileName);
            pbDadosProp.Image = imagens2;
            this.Validate();
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            pbDadosProp.Image = null;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string modelo, placa,cidadeCar,fabricante, cor, estadoCar, nome, end, bairro, complemento, estadoPes, cidadePes, sexo, rg, cpf;
            int ano;

            conectar.Open();
            MySqlCommand salvar = new MySqlCommand();
            

            modelo = txtModelo.Text;
            placa = mtbPlaca.Text;
            cidadeCar = txtCidadeCar.Text;
            fabricante = cbFabricante.Text;
            cor = txtCor.Text;
            estadoCar = cbEstadoCar.Text;
            nome = txtNome.Text;
            end = txtEndereco.Text;
            bairro = txtBairro.Text;
            complemento = txtComplemento.Text;
            estadoPes = cbEstadoPes.Text;
            cidadePes = txtCidadePes.Text;
            sexo = cbSexo.Text;
            ano = Convert.ToInt16(cbAno.Text);
            rg = mtbRg.Text;
            cpf = mtbCPF.Text;

           


             if (txtModelo.Text.Length == 0 | cbFabricante.Text.Length == 0 | cbEstadoPes.Text.Length == 0 | cbEstadoCar.Text.Length == 0 | cbAno.Text.Length == 0 |
                txtNome.Text.Length == 0 | txtEndereco.Text.Length == 0 | txtCor.Text.Length == 0 | txtCidadePes.Text.Length == 0 |
                txtCidadeCar.Text.Length == 0 | txtBairro.Text.Length == 0 | mtbDatNasc.Text.Length == 0 | cbSexo.Text.Length == 0
                 | mtbPlaca.Text.Length == 0 | mtbCPF.Text.Length == 0 | mtbRg.Text.Length == 0)
            {


                MessageBox.Show("Há compos em branco, Por favor preencha todos os Campos!");
            }

            else
            {
               

                try
                {

                    salvar.CommandText = "Insert into veiculos(vei_Nome,vei_End,vei_Bairro,vei_Complemento,vei_EstadoPes,vei_CidadePes,vei_Rg,vei_Cpf,vei_DatNasc,vei_Sexo,vei_Modelo,vei_Ano,vei_Placa,vei_CidadeCar,vei_Fabricante,vei_Cor,vei_EstadoCar)values('"
                        + nome + "','" + end + "','" + bairro + "','" + complemento + "','" + estadoPes + "','" + cidadePes + "','" + rg + "','" + cpf + "','" + mtbDatNasc.Text + "','" + sexo + "','" + modelo + "'," + ano + ",'" + placa + "','" + cidadeCar + "','" + fabricante + "','" + cor + "','" + estadoCar + "')";


                    salvar.Connection = conectar;


                    salvar.ExecuteNonQuery();

                    conectar.Close();

                    MessageBox.Show("Veiculo Cadastrado Com Sucesso!");
                    txtCor.Text = "";
                    txtModelo.Text = "";
                    txtNome.Text = "";
                    txtEndereco.Text = "";
                    txtComplemento.Text = "";
                    txtCidadePes.Text = "";
                    txtCidadeCar.Text = "";
                    txtBairro.Text = "";
                    cbAno.Text = null;
                    cbEstadoCar.Text = null;
                    cbEstadoPes.Text = null;
                    cbFabricante.Text = null;
                    mtbPlaca.Text = "";
                    mtbCPF.Text = "";
                    mtbRg.Text = "";
                    mtbDatNasc.Text = "";
                    cbSexo.Text = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel salvar o seu cadastro, tente novamente mais tarde!" + Convert.ToString(ex));
                }
            }
        }

        private void btnLimpar3_Click(object sender, EventArgs e)
        {
            txtCor.Text = "";
            txtModelo.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtComplemento.Text = "";
            txtCidadePes.Text = "";
            txtCidadeCar.Text = "";
            txtBairro.Text = "";
            cbAno.Text = null;
            cbEstadoCar.Text =  null;
            cbEstadoPes.Text = null;
            cbFabricante.Text = null;
            mtbPlaca.Text = "";
            mtbCPF.Text = "";
            mtbRg.Text = "";
            mtbDatNasc.Text = "";
            cbSexo.Text = null;
           
            

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           Consulta vemConsulta = new Consulta();
            this.Hide();
            vemConsulta.ShowDialog();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = DateTime.Now.ToString("HH.mm.ss"); 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro Excluido com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


      

       

        
    }
}
