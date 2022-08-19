using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAtv.Models.ViewModels.Request
{
    public class PostTamanhoDTO
    {
        [Required(ErrorMessage = "Tamanho é  Obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Quantidade de 'Pedaços' é  Obrigatório")]
        public string Descricao { get; set; }
    }
}
