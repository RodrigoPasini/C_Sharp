namespace EstacionamentoClientes
{
    partial class FrmVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeiculos));
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lbCor = new System.Windows.Forms.Label();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.cmbNomeCliente = new System.Windows.Forms.ComboBox();
            this.btnInserirVeiculo = new System.Windows.Forms.Button();
            this.bntExcluirVeiculo = new System.Windows.Forms.Button();
            this.bntAlterarVeiculo = new System.Windows.Forms.Button();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.txtUsuarioLogado = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPesquisarMarca = new System.Windows.Forms.ComboBox();
            this.btnPesquisarMarca = new System.Windows.Forms.Button();
            this.btnPesqPlaca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisarPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.btnFecharVeiculo = new System.Windows.Forms.Button();
            this.btnLimpaVeiculos = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(106, 92);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(104, 26);
            this.txtPlaca.TabIndex = 55;
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaca.Location = new System.Drawing.Point(37, 98);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(48, 20);
            this.lbPlaca.TabIndex = 48;
            this.lbPlaca.Text = "Placa";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(37, 132);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(53, 20);
            this.lbMarca.TabIndex = 49;
            this.lbMarca.Text = "Marca";
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(106, 204);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(59, 26);
            this.txtAno.TabIndex = 58;
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(41, 210);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(38, 20);
            this.lbAno.TabIndex = 51;
            this.lbAno.Text = "Ano";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelo.Location = new System.Drawing.Point(37, 171);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(61, 20);
            this.lbModelo.TabIndex = 50;
            this.lbModelo.Text = "Modelo";
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(106, 243);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(132, 26);
            this.txtCor.TabIndex = 59;
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCor.Location = new System.Drawing.Point(41, 249);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(34, 20);
            this.lbCor.TabIndex = 52;
            this.lbCor.Text = "Cor";
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.Location = new System.Drawing.Point(37, 59);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(51, 20);
            this.lbNomeCliente.TabIndex = 47;
            this.lbNomeCliente.Text = "Nome";
            // 
            // cmbNomeCliente
            // 
            this.cmbNomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeCliente.FormattingEnabled = true;
            this.cmbNomeCliente.Location = new System.Drawing.Point(106, 58);
            this.cmbNomeCliente.Name = "cmbNomeCliente";
            this.cmbNomeCliente.Size = new System.Drawing.Size(132, 21);
            this.cmbNomeCliente.TabIndex = 54;
            this.cmbNomeCliente.SelectedIndexChanged += new System.EventHandler(this.cmbNomeCliente_SelectedIndexChanged);
            // 
            // btnInserirVeiculo
            // 
            this.btnInserirVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirVeiculo.Location = new System.Drawing.Point(149, 295);
            this.btnInserirVeiculo.Name = "btnInserirVeiculo";
            this.btnInserirVeiculo.Size = new System.Drawing.Size(98, 29);
            this.btnInserirVeiculo.TabIndex = 61;
            this.btnInserirVeiculo.Text = "Inserir";
            this.btnInserirVeiculo.UseVisualStyleBackColor = true;
            this.btnInserirVeiculo.Click += new System.EventHandler(this.btnInserirVeiculo_Click);
            // 
            // bntExcluirVeiculo
            // 
            this.bntExcluirVeiculo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bntExcluirVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExcluirVeiculo.Location = new System.Drawing.Point(377, 295);
            this.bntExcluirVeiculo.Name = "bntExcluirVeiculo";
            this.bntExcluirVeiculo.Size = new System.Drawing.Size(98, 29);
            this.bntExcluirVeiculo.TabIndex = 63;
            this.bntExcluirVeiculo.Text = "Excluir";
            this.bntExcluirVeiculo.UseVisualStyleBackColor = true;
            this.bntExcluirVeiculo.Click += new System.EventHandler(this.bntExcluirVeiculo_Click);
            // 
            // bntAlterarVeiculo
            // 
            this.bntAlterarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAlterarVeiculo.Location = new System.Drawing.Point(263, 295);
            this.bntAlterarVeiculo.Name = "bntAlterarVeiculo";
            this.bntAlterarVeiculo.Size = new System.Drawing.Size(98, 29);
            this.bntAlterarVeiculo.TabIndex = 62;
            this.bntAlterarVeiculo.Text = "Alterar";
            this.bntAlterarVeiculo.UseVisualStyleBackColor = true;
            this.bntAlterarVeiculo.Click += new System.EventHandler(this.bntAlterarVeiculo_Click);
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.txtUsuarioLogado);
            this.groupbox.Controls.Add(this.lbUsuario);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.txtID);
            this.groupbox.Controls.Add(this.cmbMarca);
            this.groupbox.Controls.Add(this.txtModelo);
            this.groupbox.Controls.Add(this.lbCor);
            this.groupbox.Controls.Add(this.txtCor);
            this.groupbox.Controls.Add(this.lbModelo);
            this.groupbox.Controls.Add(this.cmbNomeCliente);
            this.groupbox.Controls.Add(this.lbAno);
            this.groupbox.Controls.Add(this.lbNomeCliente);
            this.groupbox.Controls.Add(this.txtPlaca);
            this.groupbox.Controls.Add(this.txtAno);
            this.groupbox.Controls.Add(this.lbMarca);
            this.groupbox.Controls.Add(this.lbPlaca);
            this.groupbox.Location = new System.Drawing.Point(35, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(295, 277);
            this.groupbox.TabIndex = 53;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Veiculo";
            // 
            // txtUsuarioLogado
            // 
            this.txtUsuarioLogado.AutoSize = true;
            this.txtUsuarioLogado.Location = new System.Drawing.Point(239, 29);
            this.txtUsuarioLogado.Name = "txtUsuarioLogado";
            this.txtUsuarioLogado.Size = new System.Drawing.Size(0, 13);
            this.txtUsuarioLogado.TabIndex = 75;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(153, 25);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(72, 20);
            this.lbUsuario.TabIndex = 74;
            this.lbUsuario.Text = "Usuário: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(106, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(41, 26);
            this.txtID.TabIndex = 53;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Fiat",
            "Renault",
            "Nissan",
            "Toyota",
            "BMW",
            "Mercedes",
            "Jeep",
            "Jack",
            "Chevrolet",
            "Volkswagen",
            "Volvo"});
            this.cmbMarca.Location = new System.Drawing.Point(106, 131);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(132, 21);
            this.cmbMarca.TabIndex = 56;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(106, 165);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(132, 26);
            this.txtModelo.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPesquisarMarca);
            this.groupBox1.Controls.Add(this.btnPesquisarMarca);
            this.groupBox1.Controls.Add(this.btnPesqPlaca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPesquisarPlaca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(462, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 149);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // cmbPesquisarMarca
            // 
            this.cmbPesquisarMarca.FormattingEnabled = true;
            this.cmbPesquisarMarca.Items.AddRange(new object[] {
            "Fiat",
            "Renault",
            "Nissan",
            "Toyota",
            "BMW",
            "Mercedes",
            "Jeep",
            "Jack",
            "Chevrolet",
            "Volkswagen",
            "Volvo"});
            this.cmbPesquisarMarca.Location = new System.Drawing.Point(108, 90);
            this.cmbPesquisarMarca.Name = "cmbPesquisarMarca";
            this.cmbPesquisarMarca.Size = new System.Drawing.Size(132, 21);
            this.cmbPesquisarMarca.TabIndex = 67;
            // 
            // btnPesquisarMarca
            // 
            this.btnPesquisarMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarMarca.BackgroundImage")));
            this.btnPesquisarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarMarca.Location = new System.Drawing.Point(261, 83);
            this.btnPesquisarMarca.Name = "btnPesquisarMarca";
            this.btnPesquisarMarca.Size = new System.Drawing.Size(33, 28);
            this.btnPesquisarMarca.TabIndex = 69;
            this.btnPesquisarMarca.UseVisualStyleBackColor = true;
            this.btnPesquisarMarca.Click += new System.EventHandler(this.btnPesquisarMarca_Click);
            // 
            // btnPesqPlaca
            // 
            this.btnPesqPlaca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesqPlaca.BackgroundImage")));
            this.btnPesqPlaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesqPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqPlaca.Location = new System.Drawing.Point(261, 36);
            this.btnPesqPlaca.Name = "btnPesqPlaca";
            this.btnPesqPlaca.Size = new System.Drawing.Size(33, 28);
            this.btnPesqPlaca.TabIndex = 68;
            this.btnPesqPlaca.UseVisualStyleBackColor = true;
            this.btnPesqPlaca.Click += new System.EventHandler(this.btnPesqPlaca_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Marca";
            // 
            // txtPesquisarPlaca
            // 
            this.txtPesquisarPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarPlaca.Location = new System.Drawing.Point(108, 38);
            this.txtPesquisarPlaca.Name = "txtPesquisarPlaca";
            this.txtPesquisarPlaca.Size = new System.Drawing.Size(111, 26);
            this.txtPesquisarPlaca.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Placa";
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.AllowUserToAddRows = false;
            this.dgvVeiculos.AllowUserToDeleteRows = false;
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Location = new System.Drawing.Point(483, 167);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.Size = new System.Drawing.Size(330, 166);
            this.dgvVeiculos.TabIndex = 70;
            this.dgvVeiculos.SelectionChanged += new System.EventHandler(this.dgvVeiculos_SelectionChanged);
            // 
            // btnFecharVeiculo
            // 
            this.btnFecharVeiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharVeiculo.BackgroundImage")));
            this.btnFecharVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharVeiculo.Location = new System.Drawing.Point(791, -1);
            this.btnFecharVeiculo.Name = "btnFecharVeiculo";
            this.btnFecharVeiculo.Size = new System.Drawing.Size(33, 28);
            this.btnFecharVeiculo.TabIndex = 73;
            this.btnFecharVeiculo.TabStop = false;
            this.btnFecharVeiculo.UseVisualStyleBackColor = true;
            this.btnFecharVeiculo.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpaVeiculos
            // 
            this.btnLimpaVeiculos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLimpaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaVeiculos.Location = new System.Drawing.Point(35, 295);
            this.btnLimpaVeiculos.Name = "btnLimpaVeiculos";
            this.btnLimpaVeiculos.Size = new System.Drawing.Size(98, 29);
            this.btnLimpaVeiculos.TabIndex = 60;
            this.btnLimpaVeiculos.Text = "Limpar";
            this.btnLimpaVeiculos.UseVisualStyleBackColor = true;
            this.btnLimpaVeiculos.Click += new System.EventHandler(this.btnLimpaVeiculos_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(279, 70);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(45, 20);
            this.txtIdCliente.TabIndex = 76;
            this.txtIdCliente.Visible = false;
            // 
            // FrmVeiculos
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 375);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.btnLimpaVeiculos);
            this.Controls.Add(this.btnFecharVeiculo);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.bntAlterarVeiculo);
            this.Controls.Add(this.bntExcluirVeiculo);
            this.Controls.Add(this.btnInserirVeiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVeiculos";
            this.Text = "Cadastro Veiculo / Pesquisar";
            this.Load += new System.EventHandler(this.FrmVeiculos_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.ComboBox cmbNomeCliente;
        private System.Windows.Forms.Button btnInserirVeiculo;
        private System.Windows.Forms.Button bntExcluirVeiculo;
        private System.Windows.Forms.Button bntAlterarVeiculo;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisarPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisarMarca;
        private System.Windows.Forms.Button btnPesqPlaca;
        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.Button btnFecharVeiculo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnLimpaVeiculos;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbPesquisarMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label txtUsuarioLogado;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtIdCliente;
    }
}