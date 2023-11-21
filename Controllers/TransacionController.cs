using Microsoft.AspNetCore.Mvc;
using web.ViewModel;
using web.Service;

namespace web.Controllers;

[ApiController]
[Route("api/transaction")]
public class TransactionController : ControllerBase
{

    private readonly ITransactionService _service;

    public TransactionController(ITransactionService service)
    {
        _service = service;
    }

    [HttpGet(Name = "GetTransactions")]
     public List<TransactionViewModel> GetAllTransactions(){
        return _service.GetAllTransactions();
    }

    [HttpGet("{id}")]
    public TransactionViewModel GetTransaction(int id){
        return _service.GetTransaction(id);
    }

}
