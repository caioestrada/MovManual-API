using AutoMapper;
using MovimentosManuais.Application.ViewModels;
using MovimentosManuais.Infra.Data.Entities;

namespace MovimentosManuais.Application.AutoMapper
{
    public class ViewModelAutoMapper : Profile
    {
        protected override void Configure()
        {
            CreateMap<PRODUTO, ProdutoViewModel>()
                .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.COD_PRODUTO))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.DES_PRODUTO))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.STA_STATUS))
                .ReverseMap();
        }
    }
}
