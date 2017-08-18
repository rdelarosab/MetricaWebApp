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

        public int InsertBank(BankBE modelBE)
        {
            return new BankDA().InsertBank(modelBE);
        }

        public int UpdateBank(BankBE modelBE)
        {
            return new BankDA().UpdateBank(modelBE);
        }

        public int DeleteBank(int idBanco)
        {
            return new BankDA().DeleteBank(idBanco);
        }

        public BankBE GetBank(int idBanco)
        {
            return new BankDA().GetBank(idBanco);
        }
        


    }
}
