using System;
using System.Windows.Forms;
using AgendaContato.Forms;
using AgendaContato.Forms.CEPService;
using Models.Models;
using MySql.Data.MySqlClient;
using ProjaAgendaContato.Enums;

namespace ProjaAgendaContato
{
    public partial class Form1 : Form
    {
        public ContatoRepository ContatoRepository = new ContatoRepository();

        public CompromissosRepository CompromissosRepository = new CompromissosRepository();

        public Contatos ContatoForms = new Contatos();

        public Compromisso CompromissoForms = new Compromisso();

        public Contatos Contatos = new Contatos();

        int idContato;

        int idCompromisso;

        public Form1()
        {
            InitializeComponent();
            PopulaDataGridCompromissos();
            PopulaDataGridContatos();
            PopulaComboQuem();
        }

        #region Methods

        public void ConsultaCEP(string cep)
        {
            using (var webService = new AtendeClienteClient())
            {
                var resposta = webService.consultaCEP(cep);

                txtRua.Text = resposta.end;
                txtBairro.Text = resposta.bairro;
                txtCidade.Text = resposta.cidade;
                txtUF.Text = resposta.uf;
            }
        }

        private void AtualizaCamposForms()
        {
            ContatoForms.Nome = txtNome.Text;
            ContatoForms.Email = txtEmail.Text;
            ContatoForms.Telefone = mskTelefone.Text;
            ContatoForms.Celular = mskCelular.Text;
            ContatoForms.Rua = txtRua.Text;
            ContatoForms.Numero = Int32.Parse(txtNumero.Text);
            ContatoForms.Bairro = txtBairro.Text;
            ContatoForms.Cidade = txtCidade.Text;
            ContatoForms.UF = txtUF.Text;
            mskCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            ContatoForms.CEP = mskCEP.Text;
        }

        private void AtualizaCamposCompromisso()
        {
            CompromissoForms.Titulo = txtTitulo.Text;
            CompromissoForms.Descricao = txtDescricao.Text;
            CompromissoForms.DataInicio = dateTimeInicio.Value;
            CompromissoForms.DataFim = dateTimeFim.Value;
            CompromissoForms.Status = (Status)cbStatus.SelectedIndex;
            CompromissoForms.Id_contatos = cbQuem.SelectedIndex;
        }

        private bool ValidaForms()
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Por favor, revise o campo \"Nome\"");
                return false;
            }
            if (mskCelular.Text.Equals(""))
            {
                MessageBox.Show("Por favor, revise o campo \"Celular\"");
                return false;
            }
            if (txtRua.Text.Equals(""))
            {
                MessageBox.Show("Por favor, revise o campo \"Rua\"");
                return false;
            }
            if (txtNumero.Text.Equals(""))
            {
                MessageBox.Show("Por favor, revise o campo \"Número\"");
                return false;
            }
            if (txtBairro.Text.Equals(""))
            {
                MessageBox.Show("Por favor, revise o campo \"Bairro\"");
                return false;
            }
            if (txtCidade.Text.Equals(""))
            {
                MessageBox.Show("Por favor, revise o campo \"Cidade\"");
                return false;
            }
            if (txtUF.Text.Equals(""))
            {
                MessageBox.Show("Por favor, revise o campo \"UF\"");
                return false;
            }

            return true;
        }

        private bool ValidaFormsCompromisso()
        {
            if (txtTitulo.Equals(""))
            {
                MessageBox.Show("Por favor, revise o campo \"Título\"");
                return false;
            }
            if (txtDescricao.Equals(""))
            {
                MessageBox.Show("Por favor, revise o campo \"Descrição\"");
                return false;
            }
            if (cbStatus.Equals(-1))
            {
                MessageBox.Show("Por favor, revise o campo \"Status\"");
                return false;
            }

            return true;
        }

        private void PopulaDataGridContatos()
        {
            var listPessoas = ContatoRepository.GetContatos();
            if (listPessoas.HasRows)
                dvgContatos.DataSource = new BindingSource(listPessoas, null);
        }

        private void PopulaDataGridCompromissos()
        {
            var listCompromissos = CompromissosRepository.GetCompromissos();
            if (listCompromissos.HasRows)
                dvgCompromissos.DataSource = new BindingSource(listCompromissos, null);
        }

        private void PopulaComboQuem()
        {
            cbQuem.Items.Clear();
            MySqlDataReader readerContato = ContatoRepository.GetContatos();

            while (readerContato.Read())
            {
                string nome = readerContato.GetString("nome");
                cbQuem.Items.Add(nome);
            }
        }
        #endregion

        #region Events

        private void mskCEP_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab) || e.KeyCode.Equals(Keys.Enter))
            {
                if (mskCEP.Text.Length == 10)
                {
                    ConsultaCEP(mskCEP.Text);
                }
                else
                {
                    MessageBox.Show("Por favor, confira o CEP novamente");
                }
            }
        }

        private void btnLimparInfos_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
            mskCEP.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
        }

        private void btnSalvaContato_Click(object sender, EventArgs e)
        {
            if (ValidaForms())
            {
                AtualizaCamposForms();
                var contatoResult = ContatoRepository.Save(ContatoForms);
                if (contatoResult > 0)
                {
                    MessageBox.Show("Contato salvo!", "Pessoa adicionada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                PopulaDataGridContatos();
                PopulaComboQuem();

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ValidaForms())
            {
                AtualizaCamposForms();
                var contatoAtualizado = ContatoRepository.Update(idContato, ContatoForms);

                MessageBox.Show("Contato atualizado com sucesso");
                PopulaDataGridContatos();
                PopulaComboQuem();
            }
        }

        private void btnExcluirContato_Click(object sender, EventArgs e)
        {
            MySqlDataReader readerContato = ContatoRepository.GetContatosNome(idContato);
            while (readerContato.Read())
            {
                string nome = readerContato.GetString("nome");
                DialogResult result = MessageBox.Show($"Você tem certeza que deseja excluir {nome} da lista de contatos?", "Confirmação de exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (ContatoRepository.Delete(idContato))
                    {
                        PopulaDataGridContatos();
                        PopulaComboQuem();
                        MessageBox.Show("Contato excluído com sucesso");
                    }
                }
            }
        }

        private void dvgContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idContato = (int)dvgContatos.Rows[e.RowIndex].Cells["id"].Value;
            MySqlDataReader readerContato = ContatoRepository.GetContatosId(idContato);

            while (readerContato.Read())
            {
                int id = readerContato.GetInt32("id");
                if (id == idContato)
                {
                    txtNome.Text = readerContato.GetString("nome");
                    txtEmail.Text = readerContato.GetString("email");
                    mskTelefone.Text = readerContato.GetString("telefone");
                    mskCelular.Text = readerContato.GetString("celular");
                    txtRua.Text = readerContato.GetString("rua");
                    txtNumero.Text = readerContato.GetString("numero");
                    txtBairro.Text = readerContato.GetString("bairro");
                    txtCidade.Text = readerContato.GetString("cidade");
                    txtUF.Text = readerContato.GetString("uf");
                }
            }
        }

        private void dvgCompromissos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCompromisso = (int)dvgCompromissos.Rows[e.RowIndex].Cells["id"].Value;
            MySqlDataReader readerCompromisso = CompromissosRepository.GetCompromissos();

            while (readerCompromisso.Read())
            {
                int id = readerCompromisso.GetInt32("id");
                if (id == idCompromisso)
                {
                    int idContatoCompromisso = int.Parse(readerCompromisso.GetString("contatos_id")); //posso usar para exclusão talvez

                    MySqlDataReader readerContato = ContatoRepository.GetContatosNome(idContatoCompromisso);
                    while (readerContato.Read())
                    {
                        cbQuem.Text = readerContato.GetString("nome");
                    }
                    txtTitulo.Text = readerCompromisso.GetString("titulo");
                    txtDescricao.Text = readerCompromisso.GetString("descricao");
                    dateTimeInicio.Text = readerCompromisso.GetString("dataini");
                    dateTimeFim.Text = readerCompromisso.GetString("datafim");
                    string status = readerCompromisso.GetString("status");
                    Enum.TryParse(status, out Status status1);
                    cbStatus.SelectedIndex = (int)(Status)status1;
                }
            }
        }

        private void btnSalvarCompromisso_Click(object sender, EventArgs e)
        {
            if (ValidaFormsCompromisso())
            {
                AtualizaCamposCompromisso();
                int selectIdContato = (int)cbQuem.SelectedIndex + 1;
                var contatoResult = CompromissosRepository.Save(CompromissoForms, selectIdContato);
                if (contatoResult > 0)
                {
                    MessageBox.Show("Compromisso salvo!", "Compromisso adicionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                PopulaDataGridContatos();
                PopulaDataGridCompromissos();
            }
        }

        private void btnAtualizarCompromisso_Click(object sender, EventArgs e)
        {
            if (ValidaFormsCompromisso())
            {
                AtualizaCamposCompromisso();
                int selectIdContato = (int)cbQuem.SelectedIndex + 1;
                var contatoResult = CompromissosRepository.Update(CompromissoForms, idCompromisso, selectIdContato);

                MessageBox.Show("Compromisso atualizado!", "Compromisso atualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PopulaDataGridContatos();
                PopulaDataGridCompromissos();
            }
        }

        private void btnLimpaCompromisso_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            cbStatus.SelectedItem = null;
            cbQuem.SelectedItem = null;
            dateTimeInicio.Text = string.Empty;
            dateTimeFim.Text = string.Empty;
        }

        private void btnMostraContatos_Click(object sender, EventArgs e)
        {
            dvgContatos.BringToFront();
        }

        private void btnMostraCompromissos_Click(object sender, EventArgs e)
        {
            dvgCompromissos.BringToFront();
        }

        private void btnExcluirCompromisso_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja esse compromisso?", "Confirmação de exclusão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (CompromissosRepository.Delete(idCompromisso))
                {
                    PopulaDataGridContatos();
                    PopulaDataGridCompromissos();
                    PopulaComboQuem();
                    MessageBox.Show("Compromisso excluído com sucesso!");
                }
            }
        }
        #endregion
    }
}

