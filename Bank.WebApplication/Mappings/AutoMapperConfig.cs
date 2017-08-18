using AutoMapper;

namespace Bank.WebApplication.Mappings
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(config =>
            {
                ServiceModelToViewModelMappings.Configure(config);
                ViewModelToServiceModelMappings.Configure(config);
                ViewModelToViewModelMappings.Configure(config);
            });
        }
    }
}