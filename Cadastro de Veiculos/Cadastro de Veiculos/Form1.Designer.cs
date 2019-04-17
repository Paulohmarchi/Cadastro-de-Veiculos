namespace Cadastro_de_Veiculos
{
    partial class frmCadastroV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroV));
            this.lblCV = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar3 = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbDadosProp = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.mtbDatNasc = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbRg = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar2 = new System.Windows.Forms.Button();
            this.pbDadosProp = new System.Windows.Forms.PictureBox();
            this.txtCidadePes = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCarregar2 = new System.Windows.Forms.Button();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblEstado2 = new System.Windows.Forms.Label();
            this.cbEstadoPes = new System.Windows.Forms.ComboBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCidade2 = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbDadosVeic = new System.Windows.Forms.GroupBox();
            this.mtbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtCidadeCar = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.pbDadosVeic = new System.Windows.Forms.PictureBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cbEstadoCar = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHorario = new System.Windows.Forms.Label();
            this.gpbDadosProp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDadosProp)).BeginInit();
            this.gpbDadosVeic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDadosVeic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.BackColor = System.Drawing.Color.Transparent;
            this.lblCV.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV.Location = new System.Drawing.Point(377, 9);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(365, 46);
            this.lblCV.TabIndex = 0;
            this.lblCV.Text = "Cadastro de Veiculos";
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSair.Location = new System.Drawing.Point(1011, 427);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 40);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar3
            // 
            this.btnLimpar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLimpar3.Location = new System.Drawing.Point(250, 427);
            this.btnLimpar3.Name = "btnLimpar3";
            this.btnLimpar3.Size = new System.Drawing.Size(105, 41);
            this.btnLimpar3.TabIndex = 10;
            this.btnLimpar3.Text = "Limpar";
            this.btnLimpar3.UseVisualStyleBackColor = true;
            this.btnLimpar3.Click += new System.EventHandler(this.btnLimpar3_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnConsultar.Location = new System.Drawing.Point(132, 427);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 41);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCadastrar.Location = new System.Drawing.Point(12, 427);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 42);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbDadosProp
            // 
            this.gpbDadosProp.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadosProp.Controls.Add(this.label2);
            this.gpbDadosProp.Controls.Add(this.cbSexo);
            this.gpbDadosProp.Controls.Add(this.mtbDatNasc);
            this.gpbDadosProp.Controls.Add(this.mtbCPF);
            this.gpbDadosProp.Controls.Add(this.label1);
            this.gpbDadosProp.Controls.Add(this.mtbRg);
            this.gpbDadosProp.Controls.Add(this.btnLimpar2);
            this.gpbDadosProp.Controls.Add(this.pbDadosProp);
            this.gpbDadosProp.Controls.Add(this.txtCidadePes);
            this.gpbDadosProp.Controls.Add(this.txtComplemento);
            this.gpbDadosProp.Controls.Add(this.txtBairro);
            this.gpbDadosProp.Controls.Add(this.txtEndereco);
            this.gpbDadosProp.Controls.Add(this.txtNome);
            this.gpbDadosProp.Controls.Add(this.btnCarregar2);
            this.gpbDadosProp.Controls.Add(this.lblNascimento);
            this.gpbDadosProp.Controls.Add(this.lblEstado2);
            this.gpbDadosProp.Controls.Add(this.cbEstadoPes);
            this.gpbDadosProp.Controls.Add(this.lblRg);
            this.gpbDadosProp.Controls.Add(this.lblCidade2);
            this.gpbDadosProp.Controls.Add(this.lblComplemento);
            this.gpbDadosProp.Controls.Add(this.lblBairro);
            this.gpbDadosProp.Controls.Add(this.lblEndereço);
            this.gpbDadosProp.Controls.Add(this.lblNome);
            this.gpbDadosProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbDadosProp.Location = new System.Drawing.Point(12, 255);
            this.gpbDadosProp.Name = "gpbDadosProp";
            this.gpbDadosProp.Size = new System.Drawing.Size(1089, 166);
            this.gpbDadosProp.TabIndex = 5;
            this.gpbDadosProp.TabStop = false;
            this.gpbDadosProp.Text = "Dados do Proprietário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sexo";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(587, 125);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(141, 28);
            this.cbSexo.TabIndex = 0;
            // 
            // mtbDatNasc
            // 
            this.mtbDatNasc.Location = new System.Drawing.Point(637, 30);
            this.mtbDatNasc.Mask = "00/00/0000";
            this.mtbDatNasc.Name = "mtbDatNasc";
            this.mtbDatNasc.Size = new System.Drawing.Size(91, 26);
            this.mtbDatNasc.TabIndex = 21;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCPF.Location = new System.Drawing.Point(605, 93);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(123, 26);
            this.mtbCPF.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "CPF";
            // 
            // mtbRg
            // 
            this.mtbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRg.Location = new System.Drawing.Point(605, 61);
            this.mtbRg.Mask = "00.000.000-0";
            this.mtbRg.Name = "mtbRg";
            this.mtbRg.Size = new System.Drawing.Size(123, 26);
            this.mtbRg.TabIndex = 18;
            // 
            // btnLimpar2
            // 
            this.btnLimpar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLimpar2.Location = new System.Drawing.Point(968, 119);
            this.btnLimpar2.Name = "btnLimpar2";
            this.btnLimpar2.Size = new System.Drawing.Size(104, 35);
            this.btnLimpar2.TabIndex = 16;
            this.btnLimpar2.Text = "Limpar";
            this.btnLimpar2.UseVisualStyleBackColor = true;
            this.btnLimpar2.Click += new System.EventHandler(this.btnLimpar2_Click);
            // 
            // pbDadosProp
            // 
            this.pbDadosProp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDadosProp.Location = new System.Drawing.Point(784, 13);
            this.pbDadosProp.Name = "pbDadosProp";
            this.pbDadosProp.Size = new System.Drawing.Size(164, 138);
            this.pbDadosProp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDadosProp.TabIndex = 16;
            this.pbDadosProp.TabStop = false;
            // 
            // txtCidadePes
            // 
            this.txtCidadePes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadePes.Location = new System.Drawing.Point(297, 125);
            this.txtCidadePes.Name = "txtCidadePes";
            this.txtCidadePes.Size = new System.Drawing.Size(210, 26);
            this.txtCidadePes.TabIndex = 17;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(389, 93);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(158, 26);
            this.txtComplemento.TabIndex = 17;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(91, 93);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(187, 26);
            this.txtBairro.TabIndex = 17;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(91, 61);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(335, 26);
            this.txtEndereco.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(91, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(335, 26);
            this.txtNome.TabIndex = 17;
            // 
            // btnCarregar2
            // 
            this.btnCarregar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCarregar2.Location = new System.Drawing.Point(968, 19);
            this.btnCarregar2.Name = "btnCarregar2";
            this.btnCarregar2.Size = new System.Drawing.Size(104, 64);
            this.btnCarregar2.TabIndex = 15;
            this.btnCarregar2.Text = "Carregar";
            this.btnCarregar2.UseVisualStyleBackColor = true;
            this.btnCarregar2.Click += new System.EventHandler(this.btnCarregar2_Click);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(432, 33);
            this.lblNascimento.MinimumSize = new System.Drawing.Size(240, 15);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(240, 20);
            this.lblNascimento.TabIndex = 13;
            this.lblNascimento.Text = "Data de Nascimento";
            this.lblNascimento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEstado2
            // 
            this.lblEstado2.AutoSize = true;
            this.lblEstado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado2.Location = new System.Drawing.Point(8, 128);
            this.lblEstado2.Name = "lblEstado2";
            this.lblEstado2.Size = new System.Drawing.Size(60, 20);
            this.lblEstado2.TabIndex = 2;
            this.lblEstado2.Text = "Estado";
            // 
            // cbEstadoPes
            // 
            this.cbEstadoPes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoPes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoPes.FormattingEnabled = true;
            this.cbEstadoPes.Location = new System.Drawing.Point(73, 125);
            this.cbEstadoPes.Name = "cbEstadoPes";
            this.cbEstadoPes.Size = new System.Drawing.Size(135, 28);
            this.cbEstadoPes.TabIndex = 11;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(560, 64);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 20);
            this.lblRg.TabIndex = 0;
            this.lblRg.Text = "RG";
            // 
            // lblCidade2
            // 
            this.lblCidade2.AutoSize = true;
            this.lblCidade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade2.Location = new System.Drawing.Point(232, 128);
            this.lblCidade2.Name = "lblCidade2";
            this.lblCidade2.Size = new System.Drawing.Size(59, 20);
            this.lblCidade2.TabIndex = 0;
            this.lblCidade2.Text = "Cidade";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(280, 96);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(108, 20);
            this.lblComplemento.TabIndex = 0;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(8, 96);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereço.Location = new System.Drawing.Point(7, 64);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(78, 20);
            this.lblEndereço.TabIndex = 0;
            this.lblEndereço.Text = "Endereço";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(7, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gpbDadosVeic
            // 
            this.gpbDadosVeic.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadosVeic.Controls.Add(this.mtbPlaca);
            this.gpbDadosVeic.Controls.Add(this.txtCidadeCar);
            this.gpbDadosVeic.Controls.Add(this.txtCor);
            this.gpbDadosVeic.Controls.Add(this.txtModelo);
            this.gpbDadosVeic.Controls.Add(this.btnLimpar);
            this.gpbDadosVeic.Controls.Add(this.btnCarregar);
            this.gpbDadosVeic.Controls.Add(this.pbDadosVeic);
            this.gpbDadosVeic.Controls.Add(this.lblCidade);
            this.gpbDadosVeic.Controls.Add(this.cbFabricante);
            this.gpbDadosVeic.Controls.Add(this.lblEstado);
            this.gpbDadosVeic.Controls.Add(this.lblCor);
            this.gpbDadosVeic.Controls.Add(this.lblFabricante);
            this.gpbDadosVeic.Controls.Add(this.cbAno);
            this.gpbDadosVeic.Controls.Add(this.lblPlaca);
            this.gpbDadosVeic.Controls.Add(this.lblAno);
            this.gpbDadosVeic.Controls.Add(this.lblModelo);
            this.gpbDadosVeic.Controls.Add(this.cbEstadoCar);
            this.gpbDadosVeic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbDadosVeic.Location = new System.Drawing.Point(12, 67);
            this.gpbDadosVeic.Name = "gpbDadosVeic";
            this.gpbDadosVeic.Size = new System.Drawing.Size(1089, 182);
            this.gpbDadosVeic.TabIndex = 4;
            this.gpbDadosVeic.TabStop = false;
            this.gpbDadosVeic.Text = "Dados do Veículo";
            // 
            // mtbPlaca
            // 
            this.mtbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPlaca.Location = new System.Drawing.Point(198, 62);
            this.mtbPlaca.Mask = "aaa-0000";
            this.mtbPlaca.Name = "mtbPlaca";
            this.mtbPlaca.Size = new System.Drawing.Size(77, 26);
            this.mtbPlaca.TabIndex = 18;
            // 
            // txtCidadeCar
            // 
            this.txtCidadeCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCar.Location = new System.Drawing.Point(73, 129);
            this.txtCidadeCar.Name = "txtCidadeCar";
            this.txtCidadeCar.Size = new System.Drawing.Size(202, 26);
            this.txtCidadeCar.TabIndex = 17;
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCor.Location = new System.Drawing.Point(399, 93);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(202, 26);
            this.txtCor.TabIndex = 17;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(73, 26);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(205, 26);
            this.txtModelo.TabIndex = 17;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLimpar.Location = new System.Drawing.Point(968, 120);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 35);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCarregar.Location = new System.Drawing.Point(968, 15);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(104, 64);
            this.btnCarregar.TabIndex = 15;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // pbDadosVeic
            // 
            this.pbDadosVeic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDadosVeic.Location = new System.Drawing.Point(784, 12);
            this.pbDadosVeic.Name = "pbDadosVeic";
            this.pbDadosVeic.Size = new System.Drawing.Size(167, 164);
            this.pbDadosVeic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDadosVeic.TabIndex = 14;
            this.pbDadosVeic.TabStop = false;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(8, 132);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade";
            // 
            // cbFabricante
            // 
            this.cbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(99, 96);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(176, 28);
            this.cbFabricante.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(333, 132);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(359, 99);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(34, 20);
            this.lblCor.TabIndex = 7;
            this.lblCor.Text = "Cor";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFabricante.Location = new System.Drawing.Point(8, 99);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(85, 20);
            this.lblFabricante.TabIndex = 6;
            this.lblFabricante.Text = "Fabricante";
            // 
            // cbAno
            // 
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(73, 62);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(61, 28);
            this.cbAno.TabIndex = 4;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(147, 65);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 20);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "Placa";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(6, 65);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(38, 20);
            this.lblAno.TabIndex = 1;
            this.lblAno.Text = "Ano";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(6, 29);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo";
            // 
            // cbEstadoCar
            // 
            this.cbEstadoCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbEstadoCar.FormattingEnabled = true;
            this.cbEstadoCar.Location = new System.Drawing.Point(401, 129);
            this.cbEstadoCar.Name = "cbEstadoCar";
            this.cbEstadoCar.Size = new System.Drawing.Size(146, 28);
            this.cbEstadoCar.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHorario.Location = new System.Drawing.Point(1015, 9);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(0, 25);
            this.lblHorario.TabIndex = 14;
            // 
            // frmCadastroV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 470);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar3);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbDadosProp);
            this.Controls.Add(this.gpbDadosVeic);
            this.Controls.Add(this.lblCV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veiculos";
            this.Load += new System.EventHandler(this.frmCadastroV_Load);
            this.gpbDadosProp.ResumeLayout(false);
            this.gpbDadosProp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDadosProp)).EndInit();
            this.gpbDadosVeic.ResumeLayout(false);
            this.gpbDadosVeic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDadosVeic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbDadosProp;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.Button btnLimpar2;
        private System.Windows.Forms.PictureBox pbDadosProp;
        private System.Windows.Forms.TextBox txtCidadePes;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCarregar2;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblEstado2;
        private System.Windows.Forms.ComboBox cbEstadoPes;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCidade2;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbDadosVeic;
        private System.Windows.Forms.MaskedTextBox mtbPlaca;
        private System.Windows.Forms.TextBox txtCidadeCar;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.PictureBox pbDadosVeic;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cbEstadoCar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.MaskedTextBox mtbDatNasc;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label2;
    }
}

