
using web.DatabaseModel;
using Microsoft.EntityFrameworkCore;

namespace web.Repository;
public class TransactionRepository : ITransactionRepository

{
	private Whiyes5oContext _context;
	
	public TransactionRepository(Whiyes5oContext context){
		_context = context;
	
	}
	public List<Transaction> GetAllTransactions(){
		return _context.Transactions.Include(p => p.User).Include(p => p.TransactionType).ToList();;
	}
	
	public Transaction GetTransaction(int id){
		return _context.Transactions.Include(p => p.User).Include(p => p.TransactionType).FirstOrDefault(p => p.Id == id);;
	}


}