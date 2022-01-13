using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Projeto3.Models
{
    public class Locadora
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Automoveis> Automovel { get; set; } = new List<Automoveis>();
        public Locadora ()
        {

        }

        public Locadora(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddAutomoveis(Automoveis automoveis)
        {

            Automovel.Add(automoveis);
        }

        public double TotalAluguel(DateTime inicio, DateTime final)
        {

            return Automovel.Sum(automoveis => automoveis.TotalAluguel(inicio, final)); 
        }
    }
}
