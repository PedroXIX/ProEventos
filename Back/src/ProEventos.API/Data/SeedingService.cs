using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class SeedingService
    {
        private readonly DataContext _context;

        public SeedingService(DataContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Eventos.Any())
            {
                return; //DB has been seeded(populado)
            }
            
            Evento v1= new Evento(1, "Belo Horizonte",  "12/02/2021","Angular 11 e .NET", 250, "1", "foto.png");
            Evento v2= new Evento(2, "São Paulo",  "13/02/2021","Angular e suas", 300, "2", "foto2.png");
            Evento v3= new Evento(3, "Rio de Janeiro",  "14/02/2021","Angular 11 o que", 100, "3", "foto3.jpg");

             _context.Eventos.AddRange(v1, v2,v3);

             _context.SaveChanges();
        }
    }
}