using Models.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AgendaContato.Forms
{
    public class ContatoRepository
    {
        public Int32 Save(Contatos contatos)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            
            try
            {
                return SaveContatos(contatos, conn);
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SaveContatos(Contatos contatos, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_CONTATOS, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = contatos.Nome;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = contatos.Telefone;
                cmd.Parameters.Add("@celular", MySqlDbType.VarChar, 15).Value = contatos.Celular;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = contatos.Email;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = contatos.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = contatos.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = contatos.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = contatos.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = contatos.UF;

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool Update(int id, Contatos contatos)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_CONTATOS, conn);
                cmd.Parameters.Add("@idContato", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = contatos.Nome;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = contatos.Telefone;
                cmd.Parameters.Add("@celular", MySqlDbType.VarChar, 15).Value = contatos.Celular;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = contatos.Email;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = contatos.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = contatos.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = contatos.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = contatos.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = contatos.UF;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool Delete(int id)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_CONTATO, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        internal MySqlDataReader GetContatos()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONTATOS, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Preenche o datagridview / mesmo método que o de cima, mas aceitando um idContato
        internal MySqlDataReader GetContatosId(int idContato)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONTATOS, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Informa o nome do contato que está sendo excluído
        internal MySqlDataReader GetContatosNome(int id)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_A_CONTATO_BY_ID, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private const String SQL_DELETE_CONTATO = @"DELETE from contatos WHERE id = @id";

        private const String SQL_SELECT_CONTATOS = "SELECT id, nome, telefone, celular, email, rua, numero, bairro, cidade, uf from contatos";

        private const String SQL_SELECT_A_CONTATO_BY_ID = "SELECT nome FROM contatos WHERE id = @id;";

        private const String SQL_UPDATE_CONTATOS = @"UPDATE contatos cont
                                                    SET cont.nome = @nome,
                                                    cont.telefone = @telefone,
                                                    cont.celular = @celular,
                                                    cont.email = @email,
                                                    cont.rua = @rua,
                                                    cont.numero = @numero,
                                                    cont.bairro = @bairro,
                                                    cont.cidade = @cidade,
                                                    cont.uf = @uf
                                                    WHERE cont.id = @idContato"; 

        private const String SQL_INSERT_CONTATOS = @"INSERT INTO contatos 
                                                    (nome,
                                                    telefone,
                                                    celular,
                                                    email,
                                                    rua,
                                                    numero,
                                                    bairro,
                                                    cidade,
                                                    uf)
                                                    VALUES
                                                    (@nome,
                                                    @telefone,
                                                    @celular,
                                                    @email,
                                                    @rua,
                                                    @numero,
                                                    @bairro,
                                                    @cidade,
                                                    @uf)";
    }
}
