using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Projeto3.Models
{
    public class Automoveis
    {
        [key]
        public int Id { get; set; }
        public int placa { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public double ValorAluguel { get; set; }
        public Locadora Locadora { get; set; }
        public int LocadoraId { get; set; }

        public ICollection<VeiculoAlugado> Aluguel { get; set; } = new List<VeiculoAlugado>();

        public Automoveis()
        {

        }

        public Automoveis(int placa, string modelo, DateTime anoFabricacao, double valorAluguel, Locadora locadora)
        {
            this.placa = placa;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
            ValorAluguel = valorAluguel;
            Locadora = locadora;
        }

        public void AddAluguel(VeiculoAlugado sr) 
        {
            Aluguel.Add(sr);
        }

        public void RemoveAluguel(VeiculoAlugado sr) 
        {
            Aluguel.Remove(sr);
        }

        public double TotalAluguel(DateTime inicio, DateTime final) 
        {
            return Aluguel.Where(sr => sr.Date >= inicio && sr.Date <= final).Sum(sr => sr.Amount);
        }

    }
}
