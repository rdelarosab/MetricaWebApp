using System.Collections.Generic;
using Bank.DataApplication;
using Bank.Entities;

namespace Bank.BusinessLogic
{
    public class BankBL
    {
        public List<BankBE> GetAllBanks()
        {
            return new BankDA().GetAllBanks();
        }
    }
}
