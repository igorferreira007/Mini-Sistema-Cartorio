using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaCartorio.Entidades
{
    class Mae : Pais
    {
        public Mae()
        {
        }

        public Mae(string nome, DateTime? dataNascimento, string cpf) : base(nome, dataNascimento, cpf)
        {
        }
    }
}
