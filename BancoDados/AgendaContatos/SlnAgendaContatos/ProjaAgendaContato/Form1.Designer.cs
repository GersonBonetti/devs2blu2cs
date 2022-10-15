namespace ProjaAgendaContato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvaContato = new System.Windows.Forms.Button();
            this.gbContatos = new System.Windows.Forms.GroupBox();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimparInfos = new System.Windows.Forms.Button();
            this.dvgContatos = new System.Windows.Forms.DataGridView();
            this.btnSalvarCompromisso = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dateTimeFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblQuem = new System.Windows.Forms.Label();
            this.cbQuem = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnAtualizarCompromisso = new System.Windows.Forms.Button();
            this.btnLimpaCompromisso = new System.Windows.Forms.Button();
            this.btnExcluirCompromisso = new System.Windows.Forms.Button();
            this.gpCompromisso = new System.Windows.Forms.GroupBox();
            this.btnMostraContatos = new System.Windows.Forms.Button();
            this.btnMostraCompromissos = new System.Windows.Forms.Button();
            this.dvgCompromissos = new System.Windows.Forms.DataGridView();
            this.gbContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgContatos)).BeginInit();
            this.gpCompromisso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompromissos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 51);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(20, 192);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(52, 16);
            this.lblCelular.TabIndex = 2;
            this.lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(20, 143);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 16);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(293, 192);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 16);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(293, 143);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 16);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(525, 97);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 16);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Número:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(293, 97);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(35, 16);
            this.lblRua.TabIndex = 8;
            this.lblRua.Text = "Rua:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(293, 51);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(37, 16);
            this.lblCEP.TabIndex = 9;
            this.lblCEP.Text = "CEP:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(525, 192);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(28, 16);
            this.lblUF.TabIndex = 10;
            this.lblUF.Text = "UF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(198, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(73, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskCEP
            // 
            this.mskCEP.Culture = new System.Globalization.CultureInfo("en-US");
            this.mskCEP.Location = new System.Drawing.Point(351, 48);
            this.mskCEP.Mask = "00.000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(98, 22);
            this.mskCEP.TabIndex = 6;
            this.mskCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCEP.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.mskCEP_PreviewKeyDown);
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(351, 94);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(168, 22);
            this.txtRua.TabIndex = 7;
            this.txtRua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(589, 94);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(64, 22);
            this.txtNumero.TabIndex = 8;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(351, 140);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(168, 22);
            this.txtBairro.TabIndex = 9;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(351, 189);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(168, 22);
            this.txtCidade.TabIndex = 10;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(559, 189);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(55, 22);
            this.txtUF.TabIndex = 11;
            this.txtUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(90, 140);
            this.mskTelefone.Mask = "(00) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(124, 22);
            this.mskTelefone.TabIndex = 4;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(90, 189);
            this.mskCelular.Mask = "(00) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(124, 22);
            this.mskCelular.TabIndex = 5;
            this.mskCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalvaContato
            // 
            this.btnSalvaContato.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSalvaContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvaContato.Location = new System.Drawing.Point(542, 255);
            this.btnSalvaContato.Name = "btnSalvaContato";
            this.btnSalvaContato.Size = new System.Drawing.Size(111, 30);
            this.btnSalvaContato.TabIndex = 15;
            this.btnSalvaContato.Text = "Salvar Contato";
            this.btnSalvaContato.UseVisualStyleBackColor = false;
            this.btnSalvaContato.Click += new System.EventHandler(this.btnSalvaContato_Click);
            // 
            // gbContatos
            // 
            this.gbContatos.BackColor = System.Drawing.Color.Pink;
            this.gbContatos.Controls.Add(this.btnExcluirContato);
            this.gbContatos.Controls.Add(this.btnAtualizar);
            this.gbContatos.Controls.Add(this.btnLimparInfos);
            this.gbContatos.Controls.Add(this.lblNome);
            this.gbContatos.Controls.Add(this.btnSalvaContato);
            this.gbContatos.Controls.Add(this.lblCelular);
            this.gbContatos.Controls.Add(this.mskCelular);
            this.gbContatos.Controls.Add(this.lblEmail);
            this.gbContatos.Controls.Add(this.mskTelefone);
            this.gbContatos.Controls.Add(this.lblTelefone);
            this.gbContatos.Controls.Add(this.txtUF);
            this.gbContatos.Controls.Add(this.lblCidade);
            this.gbContatos.Controls.Add(this.txtCidade);
            this.gbContatos.Controls.Add(this.lblBairro);
            this.gbContatos.Controls.Add(this.txtBairro);
            this.gbContatos.Controls.Add(this.lblNumero);
            this.gbContatos.Controls.Add(this.txtNumero);
            this.gbContatos.Controls.Add(this.lblRua);
            this.gbContatos.Controls.Add(this.txtRua);
            this.gbContatos.Controls.Add(this.lblCEP);
            this.gbContatos.Controls.Add(this.mskCEP);
            this.gbContatos.Controls.Add(this.lblUF);
            this.gbContatos.Controls.Add(this.txtEmail);
            this.gbContatos.Controls.Add(this.txtNome);
            this.gbContatos.Location = new System.Drawing.Point(12, 12);
            this.gbContatos.Name = "gbContatos";
            this.gbContatos.Size = new System.Drawing.Size(667, 304);
            this.gbContatos.TabIndex = 1;
            this.gbContatos.TabStop = false;
            this.gbContatos.Text = "Contato";
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.BackColor = System.Drawing.Color.Tomato;
            this.btnExcluirContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirContato.Location = new System.Drawing.Point(292, 255);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(119, 30);
            this.btnExcluirContato.TabIndex = 13;
            this.btnExcluirContato.Text = "Excluir Contato";
            this.btnExcluirContato.UseVisualStyleBackColor = false;
            this.btnExcluirContato.Click += new System.EventHandler(this.btnExcluirContato_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Khaki;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(417, 255);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(119, 30);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar Contato";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnLimparInfos
            // 
            this.btnLimparInfos.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimparInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparInfos.Location = new System.Drawing.Point(23, 255);
            this.btnLimparInfos.Name = "btnLimparInfos";
            this.btnLimparInfos.Size = new System.Drawing.Size(111, 30);
            this.btnLimparInfos.TabIndex = 12;
            this.btnLimparInfos.Text = "Limpar Infos";
            this.btnLimparInfos.UseVisualStyleBackColor = false;
            this.btnLimparInfos.Click += new System.EventHandler(this.btnLimparInfos_Click);
            // 
            // dvgContatos
            // 
            this.dvgContatos.AllowUserToResizeColumns = false;
            this.dvgContatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dvgContatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgContatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgContatos.Location = new System.Drawing.Point(12, 368);
            this.dvgContatos.Name = "dvgContatos";
            this.dvgContatos.RowHeadersVisible = false;
            this.dvgContatos.RowHeadersWidth = 51;
            this.dvgContatos.RowTemplate.Height = 24;
            this.dvgContatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgContatos.Size = new System.Drawing.Size(1187, 291);
            this.dvgContatos.TabIndex = 25;
            this.dvgContatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgContatos_CellDoubleClick);
            // 
            // btnSalvarCompromisso
            // 
            this.btnSalvarCompromisso.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSalvarCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCompromisso.Location = new System.Drawing.Point(379, 254);
            this.btnSalvarCompromisso.Name = "btnSalvarCompromisso";
            this.btnSalvarCompromisso.Size = new System.Drawing.Size(100, 30);
            this.btnSalvarCompromisso.TabIndex = 18;
            this.btnSalvarCompromisso.Text = "Salvar";
            this.btnSalvarCompromisso.UseVisualStyleBackColor = false;
            this.btnSalvarCompromisso.Click += new System.EventHandler(this.btnSalvarCompromisso_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(27, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(23, 92);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(72, 16);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(22, 218);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(73, 16);
            this.lblDataInicio.TabIndex = 2;
            this.lblDataInicio.Text = "Data início:";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(302, 218);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(59, 16);
            this.lblDataFim.TabIndex = 4;
            this.lblDataFim.Text = "Data fim:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(302, 178);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // dateTimeFim
            // 
            this.dateTimeFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFim.Location = new System.Drawing.Point(367, 215);
            this.dateTimeFim.Name = "dateTimeFim";
            this.dateTimeFim.Size = new System.Drawing.Size(112, 22);
            this.dateTimeFim.TabIndex = 20;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicio.Location = new System.Drawing.Point(102, 215);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(119, 22);
            this.dateTimeInicio.TabIndex = 19;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(102, 47);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(377, 22);
            this.txtTitulo.TabIndex = 17;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(102, 86);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(377, 72);
            this.txtDescricao.TabIndex = 18;
            // 
            // lblQuem
            // 
            this.lblQuem.AutoSize = true;
            this.lblQuem.Location = new System.Drawing.Point(22, 178);
            this.lblQuem.Name = "lblQuem";
            this.lblQuem.Size = new System.Drawing.Size(75, 16);
            this.lblQuem.TabIndex = 25;
            this.lblQuem.Text = "Com quem:";
            // 
            // cbQuem
            // 
            this.cbQuem.FormattingEnabled = true;
            this.cbQuem.Location = new System.Drawing.Point(100, 175);
            this.cbQuem.Name = "cbQuem";
            this.cbQuem.Size = new System.Drawing.Size(188, 24);
            this.cbQuem.TabIndex = 26;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Inativo",
            "Ativo",
            "Concluído",
            "Remarcado"});
            this.cbStatus.Location = new System.Drawing.Point(355, 175);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(127, 24);
            this.cbStatus.TabIndex = 27;
            // 
            // btnAtualizarCompromisso
            // 
            this.btnAtualizarCompromisso.BackColor = System.Drawing.Color.Khaki;
            this.btnAtualizarCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarCompromisso.Location = new System.Drawing.Point(261, 254);
            this.btnAtualizarCompromisso.Name = "btnAtualizarCompromisso";
            this.btnAtualizarCompromisso.Size = new System.Drawing.Size(100, 30);
            this.btnAtualizarCompromisso.TabIndex = 17;
            this.btnAtualizarCompromisso.Text = "Atualizar\r\n";
            this.btnAtualizarCompromisso.UseVisualStyleBackColor = false;
            this.btnAtualizarCompromisso.Click += new System.EventHandler(this.btnAtualizarCompromisso_Click);
            // 
            // btnLimpaCompromisso
            // 
            this.btnLimpaCompromisso.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpaCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpaCompromisso.Location = new System.Drawing.Point(25, 254);
            this.btnLimpaCompromisso.Name = "btnLimpaCompromisso";
            this.btnLimpaCompromisso.Size = new System.Drawing.Size(100, 30);
            this.btnLimpaCompromisso.TabIndex = 16;
            this.btnLimpaCompromisso.Text = "Limpar Infos";
            this.btnLimpaCompromisso.UseVisualStyleBackColor = false;
            this.btnLimpaCompromisso.Click += new System.EventHandler(this.btnLimpaCompromisso_Click);
            // 
            // btnExcluirCompromisso
            // 
            this.btnExcluirCompromisso.BackColor = System.Drawing.Color.Tomato;
            this.btnExcluirCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCompromisso.Location = new System.Drawing.Point(143, 254);
            this.btnExcluirCompromisso.Name = "btnExcluirCompromisso";
            this.btnExcluirCompromisso.Size = new System.Drawing.Size(100, 30);
            this.btnExcluirCompromisso.TabIndex = 16;
            this.btnExcluirCompromisso.Text = "Excluir\r\n";
            this.btnExcluirCompromisso.UseVisualStyleBackColor = false;
            this.btnExcluirCompromisso.Click += new System.EventHandler(this.btnExcluirCompromisso_Click);
            // 
            // gpCompromisso
            // 
            this.gpCompromisso.BackColor = System.Drawing.Color.Pink;
            this.gpCompromisso.Controls.Add(this.btnExcluirCompromisso);
            this.gpCompromisso.Controls.Add(this.btnLimpaCompromisso);
            this.gpCompromisso.Controls.Add(this.btnAtualizarCompromisso);
            this.gpCompromisso.Controls.Add(this.cbStatus);
            this.gpCompromisso.Controls.Add(this.btnSalvarCompromisso);
            this.gpCompromisso.Controls.Add(this.cbQuem);
            this.gpCompromisso.Controls.Add(this.lblQuem);
            this.gpCompromisso.Controls.Add(this.txtDescricao);
            this.gpCompromisso.Controls.Add(this.txtTitulo);
            this.gpCompromisso.Controls.Add(this.dateTimeInicio);
            this.gpCompromisso.Controls.Add(this.dateTimeFim);
            this.gpCompromisso.Controls.Add(this.lblStatus);
            this.gpCompromisso.Controls.Add(this.lblDataFim);
            this.gpCompromisso.Controls.Add(this.lblDataInicio);
            this.gpCompromisso.Controls.Add(this.lblDescricao);
            this.gpCompromisso.Controls.Add(this.lblTitulo);
            this.gpCompromisso.Location = new System.Drawing.Point(685, 13);
            this.gpCompromisso.Name = "gpCompromisso";
            this.gpCompromisso.Size = new System.Drawing.Size(514, 303);
            this.gpCompromisso.TabIndex = 16;
            this.gpCompromisso.TabStop = false;
            this.gpCompromisso.Text = "Compromisso";
            // 
            // btnMostraContatos
            // 
            this.btnMostraContatos.Location = new System.Drawing.Point(21, 335);
            this.btnMostraContatos.Name = "btnMostraContatos";
            this.btnMostraContatos.Size = new System.Drawing.Size(158, 23);
            this.btnMostraContatos.TabIndex = 26;
            this.btnMostraContatos.Text = "Mostrar Contatos";
            this.btnMostraContatos.UseVisualStyleBackColor = true;
            this.btnMostraContatos.Click += new System.EventHandler(this.btnMostraContatos_Click);
            // 
            // btnMostraCompromissos
            // 
            this.btnMostraCompromissos.Location = new System.Drawing.Point(1008, 335);
            this.btnMostraCompromissos.Name = "btnMostraCompromissos";
            this.btnMostraCompromissos.Size = new System.Drawing.Size(180, 23);
            this.btnMostraCompromissos.TabIndex = 27;
            this.btnMostraCompromissos.Text = "Mostrar Compromissos";
            this.btnMostraCompromissos.UseVisualStyleBackColor = true;
            this.btnMostraCompromissos.Click += new System.EventHandler(this.btnMostraCompromissos_Click);
            // 
            // dvgCompromissos
            // 
            this.dvgCompromissos.AllowUserToResizeColumns = false;
            this.dvgCompromissos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dvgCompromissos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgCompromissos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCompromissos.Location = new System.Drawing.Point(12, 368);
            this.dvgCompromissos.Name = "dvgCompromissos";
            this.dvgCompromissos.RowHeadersVisible = false;
            this.dvgCompromissos.RowHeadersWidth = 51;
            this.dvgCompromissos.RowTemplate.Height = 24;
            this.dvgCompromissos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgCompromissos.Size = new System.Drawing.Size(1187, 291);
            this.dvgCompromissos.TabIndex = 28;
            this.dvgCompromissos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCompromissos_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 671);
            this.Controls.Add(this.dvgCompromissos);
            this.Controls.Add(this.btnMostraCompromissos);
            this.Controls.Add(this.btnMostraContatos);
            this.Controls.Add(this.gpCompromisso);
            this.Controls.Add(this.dvgContatos);
            this.Controls.Add(this.gbContatos);
            this.Name = "Form1";
            this.Text = "SIstema Para Agenda de Contatos";
            this.gbContatos.ResumeLayout(false);
            this.gbContatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgContatos)).EndInit();
            this.gpCompromisso.ResumeLayout(false);
            this.gpCompromisso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompromissos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Button btnSalvaContato;
        private System.Windows.Forms.GroupBox gbContatos;
        private System.Windows.Forms.Button btnLimparInfos;
        private System.Windows.Forms.DataGridView dvgContatos;
        private System.Windows.Forms.Button btnExcluirContato;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvarCompromisso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dateTimeFim;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblQuem;
        private System.Windows.Forms.ComboBox cbQuem;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnAtualizarCompromisso;
        private System.Windows.Forms.Button btnLimpaCompromisso;
        private System.Windows.Forms.Button btnExcluirCompromisso;
        private System.Windows.Forms.GroupBox gpCompromisso;
        private System.Windows.Forms.Button btnMostraContatos;
        private System.Windows.Forms.Button btnMostraCompromissos;
        private System.Windows.Forms.DataGridView dvgCompromissos;
    }
}

