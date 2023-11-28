using web.DatabaseModel;

namespace web.Repository;

public interface ITransactionRepository{

	List<Transaction> GetAllTransactions();
	
	Transaction GetTransaction(int id);	
}