using System.ComponentModel.DataAnnotations;

namespace PizzariaAtv.Models.ViewModels.Responsive
{
    public class GetTamanhosDTO
    {
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Pedaços")]
        public string Pedacos { get; set; }
    }
}
