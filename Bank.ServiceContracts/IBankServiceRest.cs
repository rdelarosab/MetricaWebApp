using System.Collections.Generic;
using System.ServiceModel;
using Bank.Entities;

namespace Bank.ServiceContracts
{
    [ServiceContract]
    public interface IBankServiceRest
    {
        [OperationContract]
        List<OrderBE> GetAllOrdersFilter(int idSucursal, int moneda);
    }
}
