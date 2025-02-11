﻿using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Interfaces.Repositories
{
    public interface IMateriaRepositorio
    {
        IList<Materia> ObterTodos(Paginacao paginacao);
        Materia ObterPorId(Guid id);
        void Inserir(Materia materia);
        void Excluir(Materia materia);
        void Atualizar(Materia materia);
        public int ObterTotal();
    }
}
