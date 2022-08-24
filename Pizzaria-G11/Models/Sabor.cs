using PizzariAtv.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariAtv.Models
{
    public class Sabor : IEnterface
    {
        public Sabor(string nome, string imagemURL,string descricao)
        {
            DataCadastro = DataCadastro;
            DataAlteracao = DataCadastro;
            Nome = nome;
            ImagemURL = imagemURL;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        [Display (Name ="Sabor")]
        public string Nome { get; private set; }
        [Display(Name = "Ilustração")]
        public string ImagemURL { get; private set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        #region relacionamento
        public List<PizzasSabores> PizzasSabores { get; private set; }
        #endregion

        public void AtualizarDados(string nome ,string imagemURL, string descricao)
        {
            Nome = nome;
            ImagemURL = imagemURL;
            Descricao = descricao;
            DataAlteracao = DateTime.Now;
        }
    }
}
