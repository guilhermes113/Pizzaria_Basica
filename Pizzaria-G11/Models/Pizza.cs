using PizzariAtv.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariAtv.Models
{
    public class Pizza : IEnterface
    {
        public Pizza(string nome, string descricao, decimal preco, string imagemURL,int tamanhoId)
        {
            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            ImagemURL = imagemURL;
            TamanhoId = tamanhoId;
        }

        public int Id { get; private set; }
            public DateTime DataCadastro { get; private set; }
            public DateTime DataAlteracao { get; private set; }
            [Display(Name = "Nome")]
            public string Nome { get; private set; }
            [Display(Name = "Descrição")]
             public string Descricao { get; private set; }
            [Display(Name = "Imagem")]
            public string ImagemURL { get; private set; }
            [Display(Name ="Preço")]
            public decimal Preco { get; private set; }
            
        #region Relacionamento
            public int TamanhoId { get; set; }
            public Tamanho Tamanho { get; private set; }
            public List<PizzasSabores> PizzasSabores { get; private set; }
        #endregion

        public void AtualizarDados(string nome, string descricao,decimal novoPreco, string imagemURL)
            {
                if  (nome.Length < 3 || novoPreco < 0)
                {
                    return;
                }
                Nome = nome;
                Descricao = descricao;
                Preco = novoPreco;
                ImagemURL = imagemURL;

                DataAlteracao = DateTime.Now;
            }
    }
}
