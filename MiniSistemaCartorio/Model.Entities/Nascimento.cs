using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaCartorio.Entidades
{
    class Nascimento
    {
        public int Id { get; set; }
        public DateTime? DataRegistro { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string NomeRegistrado { get; set; }
        public Pais Pai { get; set; }
        public Pais Mae { get; set; }

        public Nascimento()
        {
        }

        public Nascimento(DateTime? dataRegistro, DateTime? dataNascimento, string nomeRegistrado, Pais pai, Pais mae)
        {
            DataRegistro = dataRegistro;
            DataNascimento = dataNascimento;
            NomeRegistrado = nomeRegistrado;
            Pai = pai;
            Mae = mae;
        }
    }
}
