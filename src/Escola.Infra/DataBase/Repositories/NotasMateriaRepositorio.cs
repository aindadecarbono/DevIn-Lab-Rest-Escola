using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.DataBase.Repositories
{
    public class NotasMateriaRepositorio : INotasMateriaRepositorio
    {
        private readonly EscolaDBContexto _contexto;
        public NotasMateriaRepositorio(EscolaDBContexto contexto)
        {
            _contexto = contexto;
        }
        public void Atualizar(NotasMateria notasMateria)
        {
            _contexto.NotasMaterias.Update(notasMateria);
            _contexto.SaveChanges();
        }

        public void Excluir(NotasMateria notasMateria)
        {
            _contexto.NotasMaterias.Remove(notasMateria);
            _contexto.SaveChanges();
        }

        public void Inserir(NotasMateria notasMateria)
        {
            _contexto.NotasMaterias.Add(notasMateria);
            _contexto.SaveChanges();
        }

        public NotasMateria ObterPorId(Guid id)
        {
            return _contexto.NotasMaterias.Find(id);
        }

        public IList<NotasMateria> ObterTodos(Paginacao paginacao)
        {
            return _contexto.NotasMaterias
                            .Take(paginacao.Take)
                            .Skip(paginacao.Skip)
                            .ToList();
        }

        public int ObterTotal()
        {
            return _contexto.NotasMaterias.Count();
        }
    }
}
