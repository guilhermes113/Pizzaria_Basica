using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAtv.Models.ViewModels.Request
{
    public class PostPizzaDTO
    {
        [Required(ErrorMessage = "Nome do Pizza é  Obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome do Pizza deve ter de 3 a 50 caractéres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Descrição do Pizza é  Obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Descrição do Pizza deve ter de 10 a 50 caractéres")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preço Obrigatorio")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "Imagem Obrigatoria")]
        public string ImagemURL { get; set; }
        [Required(ErrorMessage = "Tamanho Obrigatória")]
        public int TamanhoId { get; set; }
        public List<int> SaboresId { get; set; }
    }
}
