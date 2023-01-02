using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFCoreAvancado.Domain
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }
        public virtual IEnumerable<Funcionario> Funcionarios { get; set; }

    }
}