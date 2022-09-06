using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
    public class Materia
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public List<NotasMateria> NotasMaterias { get; set; }

    }
}
