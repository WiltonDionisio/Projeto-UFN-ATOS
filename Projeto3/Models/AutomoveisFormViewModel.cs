using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto3.Models
{
    public class AutomoveisFormViewModel
    {
        public Automoveis Automoveis { get; set; }
        public ICollection<Locadora> Locadoras { get; set; }

    }
}
