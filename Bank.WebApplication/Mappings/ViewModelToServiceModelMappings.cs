using AutoMapper;
using Bank.WebApplication.ViewModels;

namespace Bank.WebApplication.Mappings
{
    public class ViewModelToServiceModelMappings
    {
        public static void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<BankVM, ServiceBank.BankBE>();
            config.CreateMap<BranchVM, ServiceBank.BranchBE>();
            config.CreateMap<OrderVM, ServiceBank.OrderBE>();
        }
    }
}