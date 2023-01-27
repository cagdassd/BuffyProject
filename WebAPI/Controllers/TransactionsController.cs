using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() 
        {
            var result = _transactionService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            return BadRequest(result);
            
        }
        [HttpPost("add")]
        public IActionResult Add(Transaction transaction)
        {
            var result = _transactionService.Add(transaction);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Transaction transaction)
        {
            var result = _transactionService.Update(transaction);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Transaction transaction)
        {
            var result = _transactionService.Delete(transaction);
            if (result.IsSuccess) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
