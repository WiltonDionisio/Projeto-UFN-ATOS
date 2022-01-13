using Projeto3.Models.Enums;
using System;
using System.Collections.Generic;


namespace Projeto3.Models
{
    public class VeiculoAlugado
    {

        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public double Amount { get; set; }
        public StatusAluguel Status { get; set; }
        public Automoveis Automoveis { get; set; }
        
        public VeiculoAlugado()
        {

        }

        public VeiculoAlugado(int id, DateTime date, double amount, StatusAluguel status, Automoveis automoveis)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Automoveis = automoveis;
        }
    }
}
