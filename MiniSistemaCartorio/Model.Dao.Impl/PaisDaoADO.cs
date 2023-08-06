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
    class PaisDaoADO : IPaisDao
    {
        private NpgsqlConnection Conn;

        public PaisDaoADO(NpgsqlConnection conn)
        {
            Conn = conn;
        }

        public void Atualizar(Entidades.Pais obj)
        {
            throw new NotImplementedException();
        }

        public void ExcluirPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Pais obj)
        {
            try
            {
                if (obj.GetType() == typeof(Pai))
                {
                    if (Conn.State == ConnectionState.Closed)
                        Conn.Open();

                    string sql = "insert into Pai (nome, datanascimento, cpf) " +
                    "values (@nome, @datanascimento, @cpf)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, Conn);

                    cmd.Parameters.AddWithValue("nome", obj.Nome);
                    cmd.Parameters.AddWithValue("datanascimento", NpgsqlDbType.Date, (object)obj.DataNascimento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("cpf", obj.Cpf);
                    cmd.ExecuteNonQuery();

                    sql = "SELECT lastval()";
                    cmd.CommandText = sql;
                    int idGerado = Convert.ToInt32(cmd.ExecuteScalar());
                    obj.Id = idGerado;
                }
                else
                {
                    if (Conn.State == ConnectionState.Closed)
                        Conn.Open();

                    string sql = "insert into Mae (nome, datanascimento, cpf) " +
                    "values (@nome, @datanascimento, @cpf)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, Conn);

                    cmd.Parameters.AddWithValue("nome", obj.Nome);
                    cmd.Parameters.AddWithValue("datanascimento", NpgsqlDbType.Date, (object)obj.DataNascimento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("cpf", obj.Cpf);
                    cmd.ExecuteNonQuery();

                    sql = "SELECT lastval()";
                    cmd.CommandText = sql;
                    int idGerado = Convert.ToInt32(cmd.ExecuteScalar());
                    obj.Id = idGerado;
                }
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

        public Entidades.Pais PesquisarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Entidades.Pais> PesquisarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
