using MiniSistemaCartorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaCartorio.Model.Dao
{
    interface INascimentoDao
    {
        void Inserir(Nascimento obj);
        void Atualizar(Nascimento obj);
        void ExcluirPorId(int id);
        Nascimento PesquisarPorId(int id);
        List<Nascimento> PesquisarTodos();
    }
}
