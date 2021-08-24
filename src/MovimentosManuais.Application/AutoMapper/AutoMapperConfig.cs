using AutoMapper;

namespace MovimentosManuais.Application.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(map =>
            {
                map.AddProfile<ConfigViewModels>();
            });
        }
    }
}
