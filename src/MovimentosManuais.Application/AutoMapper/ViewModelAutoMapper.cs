using AutoMapper;
using MovimentosManuais.Application.ViewModels;
using MovimentosManuais.Domain.Entities;

namespace MovimentosManuais.Application.AutoMapper
{
    public class ViewModelAutoMapper : Profile
    {
        protected override void Configure()
        {
            MapProduto();
            MapProdutoCosif();
            MapMovimentoManual();
        }

        private void MapProduto()
        {
            CreateMap<PRODUTO, ProdutoViewModel>()
                            .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.COD_PRODUTO))
                            .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.DES_PRODUTO))
                            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.STA_STATUS))
                            .ForMember(dest => dest.ProdutosCosif, opt => opt.MapFrom(src => src.PRODUTO_COSIF))
                            .ReverseMap();
        }

        private void MapProdutoCosif()
        {
            CreateMap<PRODUTO_COSIF, ProdutoCosifViewModel>()
                            .ForMember(dest => dest.CodigoProduto, opt => opt.MapFrom(src => src.COD_PRODUTO))
                            .ForMember(dest => dest.CodigoCosif, opt => opt.MapFrom(src => src.COD_COSIF))
                            .ForMember(dest => dest.CodigoClassificacao, opt => opt.MapFrom(src => src.COD_CLASSIFICACAO))
                            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.STA_STATUS))
                            .ForMember(dest => dest.MovimentosManuais, opt => opt.MapFrom(src => src.MOVIMENTO_MANUAL))
                            .ReverseMap();
        }

        private void MapMovimentoManual()
        {
            CreateMap<MOVIMENTO_MANUAL, MovimentoManualViewModel>()
                            .ForMember(dest => dest.Mes, opt => opt.MapFrom(src => src.DAT_MES))
                            .ForMember(dest => dest.Ano, opt => opt.MapFrom(src => src.DAT_ANO))
                            .ForMember(dest => dest.NumeroLancamento, opt => opt.MapFrom(src => src.NUM_LANCAMENTO))
                            .ForMember(dest => dest.CodigoProduto, opt => opt.MapFrom(src => src.COD_PRODUTO))
                            .ForMember(dest => dest.CodigoCosif, opt => opt.MapFrom(src => src.COD_COSIF))
                            .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.DES_DESCRICAO))
                            .ForMember(dest => dest.DataMovimento, opt => opt.MapFrom(src => src.DAT_MOVIMENTO))
                            .ForMember(dest => dest.CodigoUsuario, opt => opt.MapFrom(src => src.COD_USUARIO))
                            .ForMember(dest => dest.Valor, opt => opt.MapFrom(src => src.VAL_VALOR))
                            .ReverseMap();
        }
    }
}
