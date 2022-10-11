namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpFormCadastro = new System.Windows.Forms.GroupBox();
            this.gpPessoaCadastro = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRisco = new System.Windows.Forms.TextBox();
            this.txtCGCCPF = new System.Windows.Forms.MaskedTextBox();
            this.gpTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rdJuridica = new System.Windows.Forms.RadioButton();
            this.rdFisica = new System.Windows.Forms.RadioButton();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnLimparPessoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gpEnderecoCadastro = new System.Windows.Forms.GroupBox();
            this.btnLimparEndereco = new System.Windows.Forms.Button();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.cboUf = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dvgPacientes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpFormCadastro.SuspendLayout();
            this.gpPessoaCadastro.SuspendLayout();
            this.gpTipoPessoa.SuspendLayout();
            this.gpEnderecoCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPacientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Location = new System.Drawing.Point(341, 20);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(125, 24);
            this.cboConvenio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(268, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convênio:";
            // 
            // gpFormCadastro
            // 
            this.gpFormCadastro.Controls.Add(this.gpPessoaCadastro);
            this.gpFormCadastro.Controls.Add(this.gpEnderecoCadastro);
            this.gpFormCadastro.Location = new System.Drawing.Point(12, 47);
            this.gpFormCadastro.Name = "gpFormCadastro";
            this.gpFormCadastro.Size = new System.Drawing.Size(1019, 201);
            this.gpFormCadastro.TabIndex = 2;
            this.gpFormCadastro.TabStop = false;
            this.gpFormCadastro.Text = "Formulário de Cadastro";
            // 
            // gpPessoaCadastro
            // 
            this.gpPessoaCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gpPessoaCadastro.Controls.Add(this.label10);
            this.gpPessoaCadastro.Controls.Add(this.txtProntuario);
            this.gpPessoaCadastro.Controls.Add(this.label9);
            this.gpPessoaCadastro.Controls.Add(this.txtRisco);
            this.gpPessoaCadastro.Controls.Add(this.txtCGCCPF);
            this.gpPessoaCadastro.Controls.Add(this.gpTipoPessoa);
            this.gpPessoaCadastro.Controls.Add(this.lblCGCCPF);
            this.gpPessoaCadastro.Controls.Add(this.txtNome);
            this.gpPessoaCadastro.Controls.Add(this.cboConvenio);
            this.gpPessoaCadastro.Controls.Add(this.btnLimparPessoa);
            this.gpPessoaCadastro.Controls.Add(this.label2);
            this.gpPessoaCadastro.Controls.Add(this.label1);
            this.gpPessoaCadastro.Location = new System.Drawing.Point(4, 36);
            this.gpPessoaCadastro.Name = "gpPessoaCadastro";
            this.gpPessoaCadastro.Size = new System.Drawing.Size(476, 141);
            this.gpPessoaCadastro.TabIndex = 1;
            this.gpPessoaCadastro.TabStop = false;
            this.gpPessoaCadastro.Text = "Pessoa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Número de Prontuário:";
            // 
            // txtProntuario
            // 
            this.txtProntuario.Location = new System.Drawing.Point(337, 60);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(100, 22);
            this.txtProntuario.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Risco:";
            // 
            // txtRisco
            // 
            this.txtRisco.Location = new System.Drawing.Point(61, 60);
            this.txtRisco.Name = "txtRisco";
            this.txtRisco.Size = new System.Drawing.Size(100, 22);
            this.txtRisco.TabIndex = 4;
            // 
            // txtCGCCPF
            // 
            this.txtCGCCPF.Culture = new System.Globalization.CultureInfo("en-US");
            this.txtCGCCPF.Location = new System.Drawing.Point(61, 104);
            this.txtCGCCPF.Mask = "000.000.000-00";
            this.txtCGCCPF.Name = "txtCGCCPF";
            this.txtCGCCPF.Size = new System.Drawing.Size(125, 22);
            this.txtCGCCPF.TabIndex = 6;
            // 
            // gpTipoPessoa
            // 
            this.gpTipoPessoa.Controls.Add(this.rdJuridica);
            this.gpTipoPessoa.Controls.Add(this.rdFisica);
            this.gpTipoPessoa.Location = new System.Drawing.Point(192, 91);
            this.gpTipoPessoa.Name = "gpTipoPessoa";
            this.gpTipoPessoa.Size = new System.Drawing.Size(171, 44);
            this.gpTipoPessoa.TabIndex = 7;
            this.gpTipoPessoa.TabStop = false;
            this.gpTipoPessoa.Text = "Tipo de Pessoa";
            // 
            // rdJuridica
            // 
            this.rdJuridica.AutoSize = true;
            this.rdJuridica.Location = new System.Drawing.Point(93, 19);
            this.rdJuridica.Name = "rdJuridica";
            this.rdJuridica.Size = new System.Drawing.Size(75, 20);
            this.rdJuridica.TabIndex = 9;
            this.rdJuridica.Text = "Jurídica";
            this.rdJuridica.UseVisualStyleBackColor = true;
            this.rdJuridica.CheckedChanged += new System.EventHandler(this.rdJuridica_CheckedChanged);
            // 
            // rdFisica
            // 
            this.rdFisica.AutoSize = true;
            this.rdFisica.Checked = true;
            this.rdFisica.Location = new System.Drawing.Point(11, 19);
            this.rdFisica.Name = "rdFisica";
            this.rdFisica.Size = new System.Drawing.Size(64, 20);
            this.rdFisica.TabIndex = 8;
            this.rdFisica.TabStop = true;
            this.rdFisica.Text = "Física";
            this.rdFisica.UseMnemonic = false;
            this.rdFisica.UseVisualStyleBackColor = true;
            this.rdFisica.CheckedChanged += new System.EventHandler(this.rdFisica_CheckedChanged);
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCGCCPF.Location = new System.Drawing.Point(16, 107);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(36, 16);
            this.lblCGCCPF.TabIndex = 5;
            this.lblCGCCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimparPessoa
            // 
            this.btnLimparPessoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimparPessoa.FlatAppearance.BorderSize = 0;
            this.btnLimparPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparPessoa.Location = new System.Drawing.Point(378, 107);
            this.btnLimparPessoa.Name = "btnLimparPessoa";
            this.btnLimparPessoa.Size = new System.Drawing.Size(89, 24);
            this.btnLimparPessoa.TabIndex = 10;
            this.btnLimparPessoa.Text = "Limpar";
            this.btnLimparPessoa.UseVisualStyleBackColor = false;
            this.btnLimparPessoa.Click += new System.EventHandler(this.btnLimparPessoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // gpEnderecoCadastro
            // 
            this.gpEnderecoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gpEnderecoCadastro.Controls.Add(this.btnLimparEndereco);
            this.gpEnderecoCadastro.Controls.Add(this.mskCep);
            this.gpEnderecoCadastro.Controls.Add(this.cboUf);
            this.gpEnderecoCadastro.Controls.Add(this.txtCidade);
            this.gpEnderecoCadastro.Controls.Add(this.txtBairro);
            this.gpEnderecoCadastro.Controls.Add(this.txtNumero);
            this.gpEnderecoCadastro.Controls.Add(this.txtRua);
            this.gpEnderecoCadastro.Controls.Add(this.label8);
            this.gpEnderecoCadastro.Controls.Add(this.label7);
            this.gpEnderecoCadastro.Controls.Add(this.label6);
            this.gpEnderecoCadastro.Controls.Add(this.label5);
            this.gpEnderecoCadastro.Controls.Add(this.label4);
            this.gpEnderecoCadastro.Controls.Add(this.label3);
            this.gpEnderecoCadastro.Location = new System.Drawing.Point(515, 36);
            this.gpEnderecoCadastro.Name = "gpEnderecoCadastro";
            this.gpEnderecoCadastro.Size = new System.Drawing.Size(499, 141);
            this.gpEnderecoCadastro.TabIndex = 11;
            this.gpEnderecoCadastro.TabStop = false;
            this.gpEnderecoCadastro.Text = "Endereço/Cadastro";
            // 
            // btnLimparEndereco
            // 
            this.btnLimparEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimparEndereco.FlatAppearance.BorderSize = 0;
            this.btnLimparEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparEndereco.Location = new System.Drawing.Point(9, 107);
            this.btnLimparEndereco.Name = "btnLimparEndereco";
            this.btnLimparEndereco.Size = new System.Drawing.Size(94, 24);
            this.btnLimparEndereco.TabIndex = 18;
            this.btnLimparEndereco.Text = "Limpar";
            this.btnLimparEndereco.UseVisualStyleBackColor = false;
            this.btnLimparEndereco.Click += new System.EventHandler(this.btnLimparEndereco_Click);
            // 
            // mskCep
            // 
            this.mskCep.Culture = new System.Globalization.CultureInfo("en-US");
            this.mskCep.Location = new System.Drawing.Point(52, 22);
            this.mskCep.Mask = "00.000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(91, 22);
            this.mskCep.TabIndex = 12;
            this.mskCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboUf
            // 
            this.cboUf.FormattingEnabled = true;
            this.cboUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboUf.Location = new System.Drawing.Point(416, 22);
            this.cboUf.Name = "cboUf";
            this.cboUf.Size = new System.Drawing.Size(51, 24);
            this.cboUf.TabIndex = 14;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(209, 22);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(167, 22);
            this.txtCidade.TabIndex = 13;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(52, 63);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(111, 22);
            this.txtBairro.TabIndex = 15;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(352, 104);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(115, 22);
            this.txtNumero.TabIndex = 17;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(254, 63);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(213, 22);
            this.txtRua.TabIndex = 16;
            this.txtRua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bairro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Número:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "UF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Logradouro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "CEP:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Properties.Resources.floppy_disk_regular;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.Location = new System.Drawing.Point(17, 13);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 50);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.btnSalvar_MouseEnter);
            this.btnSalvar.MouseLeave += new System.EventHandler(this.btnSalvar_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Location = new System.Drawing.Point(12, 572);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 78);
            this.panel1.TabIndex = 19;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(98, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(74, 50);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(953, 13);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(50, 50);
            this.btnInfo.TabIndex = 22;
            this.btnInfo.Text = "btn";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dvgPacientes);
            this.panel2.Location = new System.Drawing.Point(12, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 298);
            this.panel2.TabIndex = 4;
            // 
            // dvgPacientes
            // 
            this.dvgPacientes.AllowUserToAddRows = false;
            this.dvgPacientes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.dvgPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dvgPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dvgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgPacientes.DefaultCellStyle = dataGridViewCellStyle31;
            this.dvgPacientes.Location = new System.Drawing.Point(0, 3);
            this.dvgPacientes.Name = "dvgPacientes";
            this.dvgPacientes.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dvgPacientes.RowHeadersVisible = false;
            this.dvgPacientes.RowHeadersWidth = 51;
            this.dvgPacientes.RowTemplate.Height = 24;
            this.dvgPacientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgPacientes.Size = new System.Drawing.Size(1019, 292);
            this.dvgPacientes.TabIndex = 0;
            this.dvgPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPacientes_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpFormCadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "+Devs2Blu - Sistema de Cadastro Hospitalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpFormCadastro.ResumeLayout(false);
            this.gpPessoaCadastro.ResumeLayout(false);
            this.gpPessoaCadastro.PerformLayout();
            this.gpTipoPessoa.ResumeLayout(false);
            this.gpTipoPessoa.PerformLayout();
            this.gpEnderecoCadastro.ResumeLayout(false);
            this.gpEnderecoCadastro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPacientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpFormCadastro;
        private System.Windows.Forms.GroupBox gpTipoPessoa;
        private System.Windows.Forms.RadioButton rdJuridica;
        private System.Windows.Forms.RadioButton rdFisica;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpEnderecoCadastro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Button btnLimparPessoa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dvgPacientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtCGCCPF;
        private System.Windows.Forms.GroupBox gpPessoaCadastro;
        private System.Windows.Forms.Button btnLimparEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRisco;
    }
}

