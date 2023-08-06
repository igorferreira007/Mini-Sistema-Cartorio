using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaCartorio.DB
{
    class DbException : SystemException
    {
        public DbException(string msg) : base (msg)
        {
            
        }
    }
}
