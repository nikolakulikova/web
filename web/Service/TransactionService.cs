using web.DatabaseModel;
using web.Repository;
using web.ViewModel;

namespace web.Service;

public class TransactionService : ITransactionService{
    private readonly ITransactionRepository transactionRepository;

 	public TransactionService(ITransactionRepository transactionRepository){
 		this.transactionRepository = transactionRepository;

 	}
 	public List<TransactionViewModel> GetAllTransactions(){
	var transactionsViewModel = new List<TransactionViewModel>();
	var transactions = transactionRepository.GetAllTransactions();
	
	foreach (var transaction in transactions) {
		var transactionViewModel = new TransactionViewModel{
			AccountNumber = transaction.AccountNumber,
			Amount = transaction.Amount,
			BankCode = transaction.BankCode,
			FullName = transaction.User.Name,
			IssueDate = transaction.IssueDate,
			TransactionType = transaction.TransactionType.Name
		};
		transactionsViewModel.Add(transactionViewModel);
	}
	return transactionsViewModel;
}

 	public TransactionViewModel GetTransaction(int id){
	var transaction = transactionRepository.GetTransaction(id);
	
	var transactionsViewModel = new TransactionViewModel{
		AccountNumber = transaction.AccountNumber,
		Amount = transaction.Amount,
		BankCode = transaction.BankCode,
		FullName = transaction.User.Name,
		IssueDate = transaction.IssueDate,
		TransactionType = transaction.TransactionType.Name
	};
	
	return transactionsViewModel;
	
}
}