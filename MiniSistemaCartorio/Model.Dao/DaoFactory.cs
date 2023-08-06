using MiniSistemaCartorio.DB;
using MiniSistemaCartorio.Model.Dao.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaCartorio.Model.Dao
{
    class DaoFactory
    {
        public static INascimentoDao CriarINascimentoDao()
        {
            return new NascimentoDaoADO(Db.GetConnection());
        }

        public static IPaisDao CriarIPaisDao()
        {
            return new PaisDaoADO(Db.GetConnection());
        }
    }
}
