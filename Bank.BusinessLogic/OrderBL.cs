using System.Collections.Generic;
using Bank.DataApplication;
using Bank.Entities;

namespace Bank.BusinessLogic
{
    public class OrderBL
    {
        public List<OrderBE> GetAllOrdersFilter(int idSucursal, int moneda)
        {
            return new OrderDA().GetAllOrdersFilter(idSucursal, moneda);
        }   
    }
}
