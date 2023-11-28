using web.ViewModel;
namespace web.Service;

public interface ITransactionService{

	List<TransactionViewModel> GetAllTransactions();
	
	TransactionViewModel GetTransaction(int id);	
}