using MiniSistemaCartorio.DB;
using MiniSistemaCartorio.Entidades;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaCartorio.Model.Dao.Impl
{
    class NascimentoDaoADO : INascimentoDao
    {
        private NpgsqlConnection Conn;

        public NascimentoDaoADO(NpgsqlConnection conn)
        {
            Conn = conn;
        }

        public void Atualizar(Nascimento obj)
        {
            throw new NotImplementedException();
        }

        public void ExcluirPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Nascimento obj)
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                string sql = "insert into nascimento (dataregistro, datanascimento, nome, pai_id, mae_id) " +
                    "values (@dataregistro, @datanascimento, @nome, @pai_id, @mae_id)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Conn);
                cmd.Parameters.AddWithValue("dataregistro", NpgsqlDbType.Date, (object)obj.DataRegistro ?? DBNull.Value);
                cmd.Parameters.AddWithValue("datanascimento", NpgsqlDbType.Date, (object)obj.DataNascimento ?? DBNull.Value);
                cmd.Parameters.AddWithValue("nome", obj.NomeRegistrado);
                cmd.Parameters.AddWithValue("pai_id", obj.Pai.Id);
                cmd.Parameters.AddWithValue("mae_id", obj.Mae.Id);
                cmd.ExecuteNonQuery();

                sql = "SELECT lastval()";
                cmd.CommandText = sql;
                int idGerado = Convert.ToInt32(cmd.ExecuteScalar());
                obj.Id = idGerado;
            }
            catch (Exception ex)
            {
                throw new DbException(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }

        public Nascimento PesquisarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Nascimento> PesquisarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
