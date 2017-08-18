using AutoMapper;
using Bank.Common;
using Bank.WebApplication.ViewModels;

namespace Bank.WebApplication.Mappings
{
    public class ServiceModelToViewModelMappings
    {
        public static void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<ServiceBank.BankBE, BankVM>();
            config.CreateMap<ServiceBank.BranchBE, BranchVM>();
            config.CreateMap<ServiceBank.OrderBE, OrderVM>()
                .ForMember(d => d.TxtMoneda, o => o.MapFrom(s => SetTxtMoneda(s.Moneda)))
                .ForMember(d => d.TxtEstado, o => o.MapFrom(s => SetTxtEstado(s.Estado)));
        }


        public static string SetTxtMoneda(int moneda)
        {
            switch (moneda)
            {
                case 1:
                    return Constants.Moneda.StrSol;
                case 2:
                    return Constants.Moneda.StrDolar;
                default:
                    return Constants.Moneda.StrSol;
            }
        }

        public static string SetTxtEstado(int estado)
        {
            switch (estado)
            {
                case 1:
                    return Constants.EstadoOrden.StrPagada;
                case 2:
                    return Constants.EstadoOrden.StrDeclinada;
                case 3:
                    return Constants.EstadoOrden.StrFallida;
                case 4:
                    return Constants.EstadoOrden.StrAnulada;
                default:
                    return Constants.EstadoOrden.StrFallida;
            }
        }
    }
}