using System.Runtime.Serialization;

namespace Bank.Entities
{
    [DataContract]
    public class OrderBE
    {
        [DataMember]
        public int IdOrden { get; set; }
        [DataMember]
        public decimal Monto { get; set; }
        [DataMember]
        public int Moneda { get; set; }
        [DataMember]
        public int Estado { get; set; }
        [DataMember]
        public string FechaPago { get; set; }
        [DataMember]
        public int IdSucursal { get; set; }
    }
}
