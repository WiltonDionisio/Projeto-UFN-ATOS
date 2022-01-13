using Projeto3.Data;
using Projeto3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto3.Services
{
    public class LocadoraService
    {
        private readonly Projeto3Context _context;

        public LocadoraService(Projeto3Context context)
        {
            _context = context;
        }

        public List<Locadora> FindAll()
        {
            return _context.Locadora.OrderBy(x => x.Name).ToList();

        }
    }
}
