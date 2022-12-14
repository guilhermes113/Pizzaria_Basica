using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariAtv.Models
{
    public class PizzasSabores
    {
        public PizzasSabores(int pizzaId,int saborId)
        {
            PizzaId = pizzaId;
            SaborId = saborId;
        }
        public Pizza Pizza { get; set; }
        [Key]
        public int PizzaId { get; set; }

        public Sabor Sabor { get; set; }
        [Key]
        public int SaborId { get; set; }

    }
}
