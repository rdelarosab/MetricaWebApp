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

        public int InsertBank(BankBE modelBE)
        {
            return new BankBL().InsertBank(modelBE);
        }

        public int UpdateBank(BankBE modelBE)
        {
            return new BankBL().UpdateBank(modelBE);
        }

        public int DeleteBank(int idBanco)
        {
            return new BankBL().DeleteBank(idBanco);
        }

        public List<BranchBE> GetAllBranchs(int idBanco)
        {
            return new BranchBL().GetAllBranchs(idBanco);
        }

        public BankBE GetBank(int idBanco)
        {
            return new BankBL().GetBank(idBanco);
        }

        public int InsertBranch(BranchBE modelBE)
        {
            return new BranchBL().InsertBranch(modelBE);
        }

        public int UpdateBranch(BranchBE modelBE)
        {
            return new BranchBL().UpdateBranch(modelBE);
        }

        public int DeleteBranch(int idBanco)
        {
            return new BranchBL().DeleteBranch(idBanco);
        }

        public BranchBE GetBranch(int idBanco)
        {
            return new BranchBL().GetBranch(idBanco);
        }

        public List<OrderBE> GetAllOrdersByBank(int idBanco)
        {
            return new OrderBL().GetAllOrdersByBank(idBanco);
        }
    }
}
