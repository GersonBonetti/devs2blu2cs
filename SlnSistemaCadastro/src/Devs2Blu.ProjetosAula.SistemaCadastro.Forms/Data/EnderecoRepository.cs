using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class EnderecoRepository
    {
        public bool Save(Endereco endereco, MySqlConnection conn = null) {

            if (conn == null)
                conn = ConnectionMySQL.GetConnection();
            
            try
            {
                return (SaveEndereco(endereco, conn) > 0);

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        // Faz o retorno do ID no SQL
        private Int32 SaveEndereco(Endereco endereco, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_ENDERECO, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.VarChar, 15).Value = endereco.Pessoa.Id;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 15).Value = endereco.CEP;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = endereco.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int16).Value = endereco.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = endereco.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = endereco.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = endereco.UF;

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        internal MySqlDataReader GetPessoas()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_ENDERECO, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        
        public bool Delete(int id)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_ENDERECO, conn);
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

        #region QUERYS

        private const String SQL_SELECT_ENDERECO = @"SELECT * from endereco";

        private const String SQL_DELETE_ENDERECO = @"DELETE from endereco WHERE id_pessoa = @id";

        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco
                                                    (id_pessoa,
                                                    CEP,
                                                    rua,
                                                    numero,
                                                    bairro,
                                                    cidade,
                                                    uf)
                                                    VALUES
                                                    (@id_pessoa,
                                                    @CEP,
                                                    @rua,
                                                    @numero,
                                                    @bairro,
                                                    @cidade,
                                                    @uf)";

        #endregion
    }
}


