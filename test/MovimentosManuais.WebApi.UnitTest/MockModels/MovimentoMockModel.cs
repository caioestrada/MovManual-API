using MovimentosManuais.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace MovimentosManuais.WebApi.UnitTest.MockModels
{
    public static class MovimentoMockModel
    {
        public static List<MovimentoManualViewModel> ObterMovimentos()
        {
            return new List<MovimentoManualViewModel>
            {
                new MovimentoManualViewModel
                {
                    Mes = 2,
                    Ano= 2019,
                    NumeroLancamento = 1,
                    CodigoProduto = "001",
                    CodigoCosif = "30000001",
                    Descricao = "TEST DESC",
                    DataMovimento = DateTime.Now,
                    CodigoUsuario = "TESTE",
                    Valor = 150
                },
                new MovimentoManualViewModel
                {
                    Mes = 2,
                    Ano= 2019,
                    NumeroLancamento = 2,
                    CodigoProduto = "002",
                    CodigoCosif = "30000002",
                    Descricao = "TEST DESC 002",
                    DataMovimento = DateTime.Now,
                    CodigoUsuario = "TESTE",
                    Valor = 150
                }
            };
        }

        public static MovimentoManualViewModel ObterMovimentoCorretoParaInclusao()
        {
            return new MovimentoManualViewModel
            {
                Mes = 2,
                Ano = 2019,
                NumeroLancamento = 1,
                CodigoProduto = "001",
                CodigoCosif = "30000001",
                Descricao = "TEST DESC",
                DataMovimento = DateTime.Now,
                CodigoUsuario = "TESTE",
                Valor = 150,
                EhValido = true
            };
        }

        public static MovimentoManualViewModel ObterMovimentoComErroParaInclusao()
        {
            return new MovimentoManualViewModel
            {
                Mes = 0,
                Ano = 0,
                NumeroLancamento = 1,
                CodigoProduto = "",
                CodigoCosif = "",
                Descricao = "TEST DESC",
                DataMovimento = DateTime.Now,
                CodigoUsuario = "TESTE",
                Valor = 150,
                EhValido = false,
                Erros = new List<string> { "Erro Mes", "Erro Ano", "Erro Codigo Produto" }
            };
        }
    }
}
