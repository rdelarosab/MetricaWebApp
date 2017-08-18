using System.Collections.Generic;
using System.ServiceModel.Web;
using Bank.BusinessLogic;
using Bank.Entities;
using Bank.ServiceContracts;

namespace Bank.Service
{
    public class BankServiceRest : IBankServiceRest
    {
        [WebInvoke(
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        public List<OrderBE> GetAllOrdersFilter(int idSucursal, int moneda)
        {
            return new OrderBL().GetAllOrdersFilter(idSucursal, moneda);
        }
    }
}
