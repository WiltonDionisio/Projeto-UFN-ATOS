using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto3.Models;
using Projeto3.Models.Enums;

namespace Projeto3.Data
{
    public class SeedingService
    {
        private Projeto3Context _context;

        public SeedingService(Projeto3Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Locadora.Any() ||
                _context.Automovel.Any() ||
                _context.VeiculoAlugados.Any())
            {
                return; //DB já foi populado
            }

            Locadora LocaAuto = new Locadora();
            Locadora LocaPickUp = new Locadora();
            Locadora LocaVans = new Locadora();


            Automoveis VolkswagenGOL = new Automoveis(1, "	Volkswagen GOL GSL 1.0", new DateTime(2020, 4, 21), 89, LocaAuto);
            Automoveis VOLKSWAGENJETTA = new Automoveis(2, "VOLKSWAGEN JETTA TIP TRONIC ", new DateTime(2020, 4, 21), 150, LocaAuto);
            Automoveis TOYOTACOROLLA = new Automoveis(3, "TOYOTA COROLLA XEI ", new DateTime(2020, 4, 21), 189, LocaAuto);
            Automoveis CHEVROLETS10 = new Automoveis(4, "CHEVROLET S10 LT", new DateTime(2020, 4, 21), 189, LocaPickUp);
            Automoveis VOLKSWAGENSAVEIRO = new Automoveis(5, "VOLKSWAGEN SAVEIRO", new DateTime(2020, 4, 21), 119, LocaPickUp);
            Automoveis Sprinter = new Automoveis(6, "Sprinter", new DateTime(2020, 4, 21), 219, LocaVans);


            VeiculoAlugado aluga1 = new VeiculoAlugado();
           


            _context.Locadora.AddRange(LocaAuto, LocaPickUp, LocaVans);

            _context.Automovel.AddRange(VolkswagenGOL, VOLKSWAGENJETTA, TOYOTACOROLLA, CHEVROLETS10, VOLKSWAGENSAVEIRO, Sprinter);

            _context.VeiculoAlugados.AddRange();

            _context.SaveChanges();

        }
    }
}
