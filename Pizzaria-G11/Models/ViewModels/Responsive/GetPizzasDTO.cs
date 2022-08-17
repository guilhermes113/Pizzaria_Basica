using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariAtv.Models.ViewModels.Responsive
{
    public class GetPizzasDTO
    {
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Foto")]
        public string ImagemURL { get; set; }
        public List<string> Sabores { get; set; }
        public string Tamanho { get; set; }
    }
}

