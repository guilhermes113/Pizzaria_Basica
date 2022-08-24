using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PizzariAtv.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzariAtv.Data
{
    public class InicializadorDeDados
    {
        public static void Inicializar(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope
                    .ServiceProvider
                    .GetService<PizzariaDbContext>();

                context.Database.EnsureCreated();

                if (!context.Tamanhos.Any())
                {
                    context.Tamanhos.AddRange(new List<Tamanho>()
                    {
                        new Tamanho("Grande",8,"Caixa Grande contendo 8 Pedaços de Pizza"),
                        new Tamanho("Média",6,"Caixa Grande contendo 6 Pedaços de Pizza"),
                        new Tamanho("Pequena",4,"Caixa Grande contendo 4 Pedaços de Pizza")
                    });
                    context.SaveChanges();
                }

                if (!context.Pizzas.Any())
                {
                    context.Pizzas.AddRange(new List<Pizza>()
                    {
                        new Pizza("4 Quijos","Uma Pizzas com 4 tipos deliciosos de Queijos.",20,"https://riopardolaticinio.com.br/wp-content/uploads/2022/02/pizza4queijos-1024x819.jpg",1),
                        new Pizza("Calabresa","A clássica pizza de Calabresa que satisfaz qualquer um.",20,"https://www.clonepizza.com.br/wp-content/uploads/calabresa-1.jpg",1),
                        new Pizza("Frango com Catupiry","Outra clássica pizza de dar água na boca.",20,"https://i.pinimg.com/736x/67/ee/2a/67ee2a4762ca2f6e44deddafd4a5b3cb.jpg",1)
                       
                    });
                    context.SaveChanges();
                }

                if (!context.Sabores.Any())
                {
                    context.Sabores.AddRange(new List<Sabor>()
                    {
                        new Sabor("Mussarela","https://static.clubeextra.com.br/img/uploads/1/0/583000.jpg","A muçarela é obtida pela coagulação do leite, tratamento e corte da massa, fermentação, filagem, salga, resfriamento, embalagem e estabilização."),
                        new Sabor("Gongorzola","https://www.sabornamesa.com.br/media/k2/items/cache/3511a15ab52c89d8883bcff6c07cb25a_XL.jpg","O gorgonzola é uma variedade de queijo azul fabricado com leite de vaca, originário da localidade de Gorgonzola, nos arredores de Milão, na Itália. A sua massa é cremosa, possuindo um sabor agradável e um aroma intenso"),
                        new Sabor("Parmesão","https://www.tioaliemporioarabe.com.br/media/catalog/product/cache/1/image/542x542/9df78eab33525d08d6e5fb8d27136e95/p/r/prod-01102014-144245-261446.jpg","O parmesão é um tipo de queijo italiano, com denominação de origem controlada conhecida como Parmigiano-Reggiano."),
                        new Sabor("Provolone","http://d3ugyf2ht6aenh.cloudfront.net/stores/738/706/products/979421-mlb20799675279_072016-o-2fc23c66025007e3f615212463351667-640-0.jpg","O provolone é um queijo semiduro originário da Itália. É característico pela sua pasta filada. O leite e o coalho são batidos com uma espécie de lâminas que faz com que a pasta resulte em forma de inúmeros fios. É um queijo compacto e duro, de cor amarelada e aroma agradável."),
                        new Sabor("Catupiry","http://www.plfrios.com.br/wp-content/uploads/2018/12/catupiry-profissional-250x250.jpg","Catupiry é uma conhecida marca brasileira de requeijão. Embora consista em um marca registrada, a palavra 'catupiry' se tornou, informalmente, sinônimo para um tipo de requeijão cremoso mais denso, normalmente vendido em bisnagas."),
                        new Sabor("Calabresa","https://paocomgraxa.com/wp-content/uploads/2022/04/Porcao-de-Calabresa.1-600x599.png","Linguiça calabresa é um tipo de linguiça condimentada com pimenta calabresa. Foi criada no Brasil, mais especificamente no bairro paulistano do Bixiga, por imigrantes da Itália que se inspiraram em uma linguiça encontrada da Calábria. Essa linguiça é muito apreciada como cobertura para pizzas."),
                        new Sabor("Frango","https://t2.rg.ltmcdn.com/pt/posts/7/0/5/frango_desfiado_e_temperado_facil_9507_600.jpg","No contexto culinário, o termo frango remete a qualquer prato preparado com a carne de aves como as galinhas. No entanto, o que se chama genericamente de frango pode ainda mais três classificações distintas além do frango em si: o galeto, o frango caipira e o frango capão."),
                        new Sabor("Cebola","https://static1.conquistesuavida.com.br/ingredients/9/54/26/69/@/24722--ingredient_detail_ingredient-2.png","Cebola é o nome popular da planta cujo nome científico é Allium cepa. Em sistemas taxonómicos mais antigos, pertencia à família das Liliáceas e subfamília das alioídeas - taxonomistas mais recentes incluem-na na família das Amaryllidaceae."),
                        new Sabor("Azeitona","https://www.conservaspoli.com.br/image_adds/628_0677050001594152245.png","A azeitona ou oliva é o fruto da oliveira com grande importância agrícola na região mediterrânea como fonte de azeite.")
                    });
                    context.SaveChanges();
                }

                if (!context.PizzasSabores.Any())
                {
                    context.PizzasSabores.AddRange(new List<PizzasSabores>()
                    {
                        new PizzasSabores(1, 1),
                        new PizzasSabores(1, 2),
                        new PizzasSabores(1, 3),
                        new PizzasSabores(1, 4),
                        new PizzasSabores(2, 6),
                        new PizzasSabores(2, 9),
                        new PizzasSabores(2, 8),
                        new PizzasSabores(3, 7),
                        new PizzasSabores(3, 5),
                        new PizzasSabores(3, 9)
                   
                    });
                    context.SaveChanges();
                }
            }
        }
    }
} 