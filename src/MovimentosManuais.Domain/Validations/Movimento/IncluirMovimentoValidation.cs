using FluentValidation;
using MovimentosManuais.Domain.Entities;
using System;

namespace MovimentosManuais.Domain.Validations.Movimento
{
    public class IncluirMovimentoValidation : AbstractValidator<MOVIMENTO_MANUAL>
    {
        public IncluirMovimentoValidation()
        {
            RuleFor(x => x.DAT_MES).GreaterThan(0).LessThan(13).WithMessage("Mes deve estar entre 1 e 12!");
            RuleFor(x => x.DAT_ANO).GreaterThan(2000).LessThan(DateTime.Now.Year + 1).WithMessage($"Ano deve estar entre 2000 e {DateTime.Now.Year}!");
            RuleFor(x => x.COD_PRODUTO).NotEmpty().WithMessage("Necessário informar o codigo do produto!");
            RuleFor(x => x.COD_COSIF).NotEmpty().WithMessage("Necessário informar o codigo cosif!");
            RuleFor(x => x.VAL_VALOR).NotEqual(0).WithMessage("Necessário informar o valor!");
            RuleFor(x => x.DES_DESCRICAO).NotEmpty().WithMessage("Necessário informar o codigo cosif!");
            RuleFor(x => x.COD_PRODUTO).NotEmpty().NotEqual("0").WithMessage("Necessário informar o codigo cosif!");
            RuleFor(x => x.COD_COSIF).NotEmpty().NotEqual("0").WithMessage("Necessário informar o codigo cosif!");
        }
    }
}
