namespace Bank.WebApplication.ViewModels
{
    public class OrderVM
    {
        public int IdOrden { get; set; }
        public decimal Monto { get; set; }
        public int Moneda { get; set; }
        public int Estado { get; set; }
        public string FechaPago { get; set; }
        public int IdSucursal { get; set; }
        public int IdBanco { get; set; }
        public string TxtMoneda { get; set; }
        public string TxtEstado { get; set; }
        public string TxtSucursal { get; set; }
    }
}