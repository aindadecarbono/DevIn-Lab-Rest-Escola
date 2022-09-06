using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
    public class Boletim
    {

        public Boletim()
        {

        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid AlunoId { get; set; }

        public Aluno Aluno { get; set; }

        public bool Aprovado { get; set; }

        public List<NotasMateria> NotasMateria { get; set; }
    }
}
