using MiniSistemaCartorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaCartorio.Model.Dao
{
    interface IPaisDao
    {
        void Inserir(Pais obj);
        void Atualizar(Pais obj);
        void ExcluirPorId(int id);
        Pais PesquisarPorId(int id);
        List<Pais> PesquisarTodos();
    }
}
