namespace Cadastro_de_Veiculos
{
    partial class Consulta
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
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPesquisar.Location = new System.Drawing.Point(142, 12);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(592, 30);
            this.txtPesquisar.TabIndex = 12;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 51);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(722, 298);
            this.dgvConsulta.TabIndex = 15;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(651, 355);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 53);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExibir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExibir.Location = new System.Drawing.Point(12, 355);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(68, 53);
            this.btnExibir.TabIndex = 13;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPesquisar.Location = new System.Drawing.Point(12, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 33);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(738, 410);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnExibir);
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnPesquisar;
    }
}