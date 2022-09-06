using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Interfaces.Repositories
{
    public interface INotasMateriaRepositorio
    {
        IList<NotasMateria> ObterTodos(Paginacao paginacao);
        NotasMateria ObterPorId(Guid id);
        void Inserir(NotasMateria notasMateria);
        void Excluir(NotasMateria notasMateria);
        void Atualizar(NotasMateria notasMateria);
        public int ObterTotal();
    }
}
