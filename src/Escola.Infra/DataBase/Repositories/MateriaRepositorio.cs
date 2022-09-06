﻿using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.DataBase.Repositories
{
    public class MateriaRepositorio : IMateriaRepositorio
    {
        private readonly EscolaDBContexto _contexto;
        public MateriaRepositorio(EscolaDBContexto contexto)
        {
            _contexto = contexto;
        }

        public void Atualizar(Materia materia)
        {
            _contexto.Materias.Update(materia);
            _contexto.SaveChanges();
        }

        public void Excluir(Materia materia)
        {
            _contexto.Materias.Remove(materia);
            _contexto.SaveChanges();
        }

        public void Inserir(Materia materia)
        {
            _contexto.Materias.Add(materia);
            _contexto.SaveChanges();
        }

        public Materia ObterPorId(Guid id)
        {
            return _contexto.Materias.Find(id);
        }

        public IList<Materia> ObterTodos(Paginacao paginacao)
        {
            return _contexto.Materias
                            .Take(paginacao.Take)
                            .Skip(paginacao.Skip)
                            .ToList();
        }

        public int ObterTotal()
        {
            return _contexto.Materias.Count();
        }
    }
}
