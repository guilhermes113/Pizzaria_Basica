using Pizzaria_G11.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria_G11.Models
{
    public class Sabor : IEnterface
    {
        public Sabor(string nome, string imagemURL)
        {
            DataCadastro = DataCadastro;
            DataAlteracao = DataCadastro;
            Nome = nome;
            ImagemURL = imagemURL;
        }

        public int Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        [Display (Name ="Sabor")]
        public string Nome { get; private set; }
        [Display(Name = "Ilustração")]
        public string ImagemURL { get; private set; }
        #region relacionamento
        public List<PizzasSabores> PizzasSabores { get; private set; }
        #endregion

        public void AtualizarDados(string nome ,string imagemURL)
        {
            Nome = nome;
            ImagemURL = imagemURL;
            DataAlteracao = DateTime.Now;
        }
    }
}
