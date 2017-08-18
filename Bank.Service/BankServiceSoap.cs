using System.Collections.Generic;
using Bank.BusinessLogic;
using Bank.Entities;
using Bank.ServiceContracts;

namespace Bank.Service
{
    public class BankServiceSoap : IBankServiceSoap
    {
        public List<BankBE> GetAllBanks()
        {
            return new BankBL().GetAllBanks();
        }

        public List<BranchBE> GetAllBranchs(int idBanco)
        {
            return new BranchBL().GetAllBranchs(idBanco);
        }

        //[WebInvoke(
        //    Method = "POST",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Wrapped)]
        //public List<OrderBE> GetAllOrdersFilter(int idSucursal, int moneda)
        //{
        //    return new OrderBL().GetAllOrdersFilter(idSucursal, moneda);
        //}        
    }
}
