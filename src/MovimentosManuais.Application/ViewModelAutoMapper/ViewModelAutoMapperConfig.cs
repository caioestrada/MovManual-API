using AutoMapper;
using MovimentosManuais.Application.ViewModels;
using MovimentosManuais.Domain.Entities;

namespace MovimentosManuais.Application.AutoMapper
{
    public class ViewModelAutoMapperConfig : Profile
    {
        protected override void Configure()
        {
            MapProduto();
            MapProdutoCosif();
            MapMovimentoManual();

            MapProdutoForm();
            MapProdutoCosifForm();
        }

        private void MapProduto()
        {
            CreateMap<PRODUTO, ProdutoViewModel>()
                            .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.COD_PRODUTO))
                            .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.DES_PRODUTO))
                            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.STA_STATUS))
                            .ReverseMap();
        }

        private void MapProdutoCosif()
        {
            CreateMap<PRODUTO_COSIF, ProdutoCosifViewModel>()
                            .ForMember(dest => dest.CodigoProduto, opt => opt.MapFrom(src => src.COD_PRODUTO))
                            .ForMember(dest => dest.CodigoCosif, opt => opt.MapFrom(src => src.COD_COSIF))
                            .ForMember(dest => dest.CodigoClassificacao, opt => opt.MapFrom(src => src.COD_CLASSIFICACAO))
                            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.STA_STATUS))
                            .ForMember(dest => dest.Produto, opt => opt.MapFrom(src => src.PRODUTO))
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
                            .ForMember(dest => dest.ProdutoCosif, opt => opt.MapFrom(src => src.PRODUTO_COSIF));

            CreateMap<MovimentoManualViewModel, MOVIMENTO_MANUAL>()
                            .ForMember(dest => dest.DAT_MES, opt => opt.MapFrom(src => src.Mes))
                            .ForMember(dest => dest.DAT_ANO, opt => opt.MapFrom(src => src.Ano))
                            .ForMember(dest => dest.NUM_LANCAMENTO, opt => opt.MapFrom(src => src.NumeroLancamento))
                            .ForMember(dest => dest.COD_PRODUTO, opt => opt.MapFrom(src => src.CodigoProduto))
                            .ForMember(dest => dest.COD_COSIF, opt => opt.MapFrom(src => src.CodigoCosif))
                            .ForMember(dest => dest.DES_DESCRICAO, opt => opt.MapFrom(src => src.Descricao))
                            .ForMember(dest => dest.DAT_MOVIMENTO, opt => opt.MapFrom(src => src.DataMovimento))
                            .ForMember(dest => dest.COD_USUARIO, opt => opt.MapFrom(src => src.CodigoUsuario))
                            .ForMember(dest => dest.VAL_VALOR, opt => opt.MapFrom(src => src.Valor))
                            .ForMember(dest => dest.PRODUTO_COSIF, opt => opt.MapFrom(src => src.ProdutoCosif));
        }

        private void MapProdutoForm()
        {
            CreateMap<PRODUTO, ProdutoFormViewModel>()
                            .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.COD_PRODUTO))
                            .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.DES_PRODUTO))
                            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.STA_STATUS))
                            .ForMember(dest => dest.ProdutosCosif, opt => opt.MapFrom(src => src.PRODUTO_COSIF))
                            .ReverseMap();
        }

        private void MapProdutoCosifForm()
        {
            CreateMap<PRODUTO_COSIF, ProdutoCosifFormViewModel>()
                            .ForMember(dest => dest.CodigoProduto, opt => opt.MapFrom(src => src.COD_PRODUTO))
                            .ForMember(dest => dest.CodigoCosif, opt => opt.MapFrom(src => src.COD_COSIF))
                            .ForMember(dest => dest.CodigoClassificacao, opt => opt.MapFrom(src => src.COD_CLASSIFICACAO))
                            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.STA_STATUS))
                            .ReverseMap();
        }
    }
}
