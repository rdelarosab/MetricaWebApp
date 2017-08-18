using System.Collections.Generic;
using Bank.DataApplication;
using Bank.Entities;

namespace Bank.BusinessLogic
{
    public class BranchBL
    {
        public List<BranchBE> GetAllBranchs(int idBanco)
        {
            return new BranchDA().GetAllBranchs(idBanco);
        }

        public int InsertBranch(BranchBE modelBE)
        {
            return new BranchDA().InsertBranch(modelBE);
        }

        public int UpdateBranch(BranchBE modelBE)
        {
            return new BranchDA().UpdateBranch(modelBE);
        }

        public int DeleteBranch(int idBanco)
        {
            return new BranchDA().DeleteBranch(idBanco);
        }

        public BranchBE GetBranch(int idBanco)
        {
            return new BranchDA().GetBranch(idBanco);
        }
    }
}
