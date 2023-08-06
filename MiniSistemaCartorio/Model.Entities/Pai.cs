using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaCartorio.Entidades
{
    class Pai : Pais
    {
        public Pai()
        {
        }

        public Pai(string nome, DateTime? dataNascimento, string cpf) : base(nome, dataNascimento, cpf)
        {
        }
    }
}
