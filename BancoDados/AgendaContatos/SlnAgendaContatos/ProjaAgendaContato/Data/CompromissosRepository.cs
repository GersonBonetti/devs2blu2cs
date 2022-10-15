using Models.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AgendaContato.Forms
{
    public class CompromissosRepository
    {
        public Int32 Save(Compromisso compromisso, Int32 idContato)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                return SaveCompromisso(compromisso, conn, idContato);
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SaveCompromisso(Compromisso compromisso, MySqlConnection conn, Int32 idContato)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_COMPROMISSOS, conn);
                cmd.Parameters.Add("@contatos_id", MySqlDbType.Int32).Value = idContato;
                cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = compromisso.Titulo;
                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 255).Value = compromisso.Descricao;
                cmd.Parameters.Add("@dataini", MySqlDbType.DateTime).Value = compromisso.DataInicio;
                cmd.Parameters.Add("@datafim", MySqlDbType.DateTime).Value = compromisso.DataFim;
                cmd.Parameters.Add("@status", MySqlDbType.Enum).Value = compromisso.Status;

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool Update(Compromisso compromisso, int idCompromisso, int selectIdContato)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_COMPROMISSOS, conn);
                cmd.Parameters.Add("@idContato", MySqlDbType.Int32).Value = selectIdContato;
                cmd.Parameters.Add("@idCompromisso", MySqlDbType.Int32).Value = idCompromisso;
                cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = compromisso.Titulo;
                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 255).Value = compromisso.Descricao;
                cmd.Parameters.Add("@dataini", MySqlDbType.DateTime).Value = compromisso.DataInicio;
                cmd.Parameters.Add("@datafim", MySqlDbType.DateTime).Value = compromisso.DataFim;
                cmd.Parameters.Add("@status", MySqlDbType.Enum).Value = compromisso.Status;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        internal MySqlDataReader GetCompromissos()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_COMPROMISSOS, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        internal MySqlDataReader GetCompromissoId(int idCompromisso)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_COMPROMISSOS, conn);
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
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_COMPROMISSO, conn);
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

        //private const String SQL_SELECT_COMPROMISSOS_BY_ID = "SELECT id, contatos_id, titulo, descricao, dataini, datafim, status from compromissos";

        private const String SQL_SELECT_COMPROMISSOS = "SELECT id, contatos_id, titulo, descricao, dataini, datafim, status from compromissos";

        private const String SQL_INSERT_COMPROMISSOS = @"INSERT INTO compromissos
                                                    (contatos_id,
                                                    titulo,
                                                    descricao,
                                                    dataini,
                                                    datafim,
                                                    status)
                                                    VALUES
                                                    (@contatos_id,
                                                    @titulo,
                                                    @descricao,
                                                    @dataini,
                                                    @datafim,
                                                    @status)";

        private const String SQL_UPDATE_COMPROMISSOS = @"UPDATE compromissos com
                                                    SET com.contatos_id = @idContato,
                                                    com.titulo = @titulo,
                                                    com.descricao = @descricao,
                                                    com.dataini = @dataini,
                                                    com.datafim = @datafim,
                                                    com.status = @status
                                                    WHERE com.id = @idCompromisso";

        private const String SQL_DELETE_COMPROMISSO = @"DELETE from compromissos WHERE id = @id";
    }
}
