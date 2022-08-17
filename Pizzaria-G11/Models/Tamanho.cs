using PizzariAtv.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariAtv.Models
{
    public class Tamanho : IEnterface
    {
        public Tamanho(string nome)
        {
            DataCadastro = DataCadastro;
            DataAlteracao = DataCadastro;
            Nome = nome;
        }

        public int Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        [Display(Name = "Tamanho")]
        public string Nome { get; private set; }
        [Display(Name = "Pedaços")]
        public string Pedacos { get; private set; }

        #region relacionamento
        public List<Pizza> Pizzas { get; private set; }
        #endregion

        public void AtualizarDados(string nome)
        {
            Nome = nome;
            DataAlteracao = DateTime.Now;
        }
    }
}
