using System.Runtime.Serialization;

namespace Bank.Entities
{
    [DataContract]
    public class BranchBE
    {
        [DataMember]
        public int IdSucursal { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public int IdBanco { get; set; }
    }
}
