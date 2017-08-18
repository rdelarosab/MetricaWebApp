using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank.WebApplication.ViewModels
{
    public class BranchVM
    {
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int IdBanco { get; set; }
    }
}