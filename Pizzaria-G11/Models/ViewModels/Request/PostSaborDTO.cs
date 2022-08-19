using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAtv.Models.ViewModels.Request
{
    public class PostSaborDTO
    {
        [Required(ErrorMessage = "Nome do sabor é  Obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O Sabor deve ter de 3 a 50 caractéres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Descrição de sabor é  Obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Descrição do Pizza deve ter de 10 a 50 caractéres")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Imagem Obrigatória")]
        public string ImagemURL { get; set; }
    }
}
