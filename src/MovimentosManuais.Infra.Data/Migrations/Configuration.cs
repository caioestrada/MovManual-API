using MovimentosManuais.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace MovimentosManuais.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MovimentosManuais.Infra.Data.Context.MovimentoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.MovimentoContext context)
        {
            AdicionarProdutos(context);
            AdicionarMovimento(context);
        }

        private static void AdicionarMovimento(MovimentoContext context)
        {
            context.MOVIMENTO_MANUAL.AddOrUpdate(
                            new Domain.Entities.MOVIMENTO_MANUAL
                            {
                                DAT_MES = 2,
                                DAT_ANO = 2019,
                                NUM_LANCAMENTO = 1,
                                COD_PRODUTO = "001",
                                COD_COSIF = "30000001",
                                DES_DESCRICAO = "TEST DESC",
                                DAT_MOVIMENTO = DateTime.Now,
                                COD_USUARIO = "TESTE",
                                VAL_VALOR = 150
                            }
                            );
        }

        private static void AdicionarProdutos(MovimentoContext context)
        {
            context.PRODUTO.AddOrUpdate(
                          new Domain.Entities.PRODUTO
                          {
                              COD_PRODUTO = "001",
                              DES_PRODUTO = "DESC 001",
                              STA_STATUS = "A",
                              PRODUTO_COSIF = CarregarProdutosCosif001()
                          },
                          new Domain.Entities.PRODUTO
                          {
                              COD_PRODUTO = "002",
                              DES_PRODUTO = "DESC 002",
                              STA_STATUS = "A",
                              PRODUTO_COSIF = CarregarProdutosCosif002()
                          }
                        );
        }

        private static List<Domain.Entities.PRODUTO_COSIF> CarregarProdutosCosif001()
        {
            return new List<Domain.Entities.PRODUTO_COSIF>
            {
                new Domain.Entities.PRODUTO_COSIF { COD_PRODUTO = "001", COD_COSIF = "30000001", COD_CLASSIFICACAO = "TRDOSQ", STA_STATUS = "A" },
                new Domain.Entities.PRODUTO_COSIF { COD_PRODUTO = "001", COD_COSIF = "40200004", COD_CLASSIFICACAO = "AGYURT", STA_STATUS = "A" }
            };
        }

        private static List<Domain.Entities.PRODUTO_COSIF> CarregarProdutosCosif002()
        {
            return new List<Domain.Entities.PRODUTO_COSIF>
            {
                new Domain.Entities.PRODUTO_COSIF { COD_PRODUTO = "002", COD_COSIF = "42450001", COD_CLASSIFICACAO = "ASOEKS", STA_STATUS = "A" },
                new Domain.Entities.PRODUTO_COSIF { COD_PRODUTO = "002", COD_COSIF = "75600102", COD_CLASSIFICACAO = "UIUROP", STA_STATUS = "A" }
            };
        }
    }
}
