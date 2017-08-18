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
        int InsertBank(BankBE modelBE);
        [OperationContract]
        int UpdateBank(BankBE modelBE);
        [OperationContract]
        int DeleteBank(int idBanco);
        [OperationContract]
        List<BranchBE> GetAllBranchs(int idBanco);
        [OperationContract]
        BankBE GetBank(int idBanco);
        [OperationContract]
        int InsertBranch(BranchBE modelBE);
        [OperationContract]
        int UpdateBranch(BranchBE modelBE);
        [OperationContract]
        int DeleteBranch(int idBanco);
        [OperationContract]
        BranchBE GetBranch(int idBanco);
        [OperationContract]
        List<OrderBE> GetAllOrdersByBank(int idBanco);
    }
}
