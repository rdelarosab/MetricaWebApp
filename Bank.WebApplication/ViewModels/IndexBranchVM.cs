using System.Collections.Generic;

namespace Bank.WebApplication.ViewModels
{
    public class IndexBranchVM
    {
        public List<BranchVM> BranchVm { get; set; }
        public int BankId { get; set; }
        public string BankName { get; set; }
    }
}