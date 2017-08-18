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
    }
}
