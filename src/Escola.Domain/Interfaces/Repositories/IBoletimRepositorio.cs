using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Interfaces.Repositories
{
    public interface IBoletimRepositorio
    {
        IList<Boletim> ObterTodos(Paginacao paginacao);
        Boletim ObterPorId(Guid id);
        void Inserir(Boletim boletim);
        void Excluir(Boletim boletim);
        void Atualizar(Boletim boletim);
        
    }
}
