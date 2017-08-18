using System.Collections.Generic;

namespace Bank.WebApplication.ViewModels
{
    public class IndexOrderVM
    {
        public List<OrderVM> OrderVm { get; set; }
        public int BankId { get; set; }
        public string BankName { get; set; }
    }
}