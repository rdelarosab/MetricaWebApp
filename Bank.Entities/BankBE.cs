using System.Runtime.Serialization;

namespace Bank.Entities
{
    [DataContract]
    public class BankBE
    {
        [DataMember]
        public int IdBanco { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Direccion { get; set; }
    }
}
