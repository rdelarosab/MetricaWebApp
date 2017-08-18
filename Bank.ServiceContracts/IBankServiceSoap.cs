using System.Collections.Generic;
using System.ServiceModel;
using Bank.Entities;

namespace Bank.ServiceContracts
{
    [ServiceContract]
    public interface IBankServiceSoap
    {
        [OperationContract]
        List<BankBE> GetAllBanks();

        [OperationContract]
        List<BranchBE> GetAllBranchs(int idBanco);
    }
}
