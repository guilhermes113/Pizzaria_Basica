using PizzariAtv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAtv.Models.ViewModels.Request
{
    public class PostPizzaDropDown
    {
        public PostPizzaDropDown()
        {
            Sabores = new List<Sabor>();
            Tamanhos = new List<Tamanho>();
        }
        public List<Sabor> Sabores { get; set; }
        public List<Tamanho> Tamanhos { get; set; }
    }
}
