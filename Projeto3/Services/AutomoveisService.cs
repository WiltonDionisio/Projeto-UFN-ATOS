using Projeto3.Data;
using Projeto3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto3.Services
{
    public class AutomoveisService
    {
        private readonly Projeto3Context _context;

        public AutomoveisService(Projeto3Context context)
        {
            _context = context;
        }

        public List<Automoveis> FindAll()
        {

            return _context.Automovel.ToList();

        }

        public void Insert(Automoveis obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Automoveis FindById(int id)
        {
            return _context.Automovel.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Automovel.Find(id);
            _context.Automovel.Remove(obj);
            _context.SaveChanges();

        }
    }
}
