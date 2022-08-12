using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria_G11.Models
{
    public class PizzasSabores
    {
        public PizzasSabores(int pizzaId,int saborId)
        {
            PizzaId = pizzaId;
            SaborId = saborId;
        }

        public Pizza Pizza { get; set; }
        public int PizzaId { get; set; }
        public Tamanho Sabor { get; set; }
        public int SaborId { get; set; }

    }
}
