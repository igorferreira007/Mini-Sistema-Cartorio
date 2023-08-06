using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaCartorio.DB
{
    class Db
    {
        private static NpgsqlConnection Conn = null;

        public static NpgsqlConnection GetConnection()
        {
            if (Conn == null)
            {
                try
                {
                    string url = @"Host=localhost;Port=5433;Username=postgres;Password=postgres;Database=MiniSistemaCartorio;";
                    Conn = new NpgsqlConnection(url);
                }
                catch (Exception ex)
                {
                    throw new DbException(ex.Message);
                }
            }
            return Conn;
        }

        public static void CloseConnection()
        {
            if (Conn != null)
            {
                Conn.Close();
            }
        }
    }
}
