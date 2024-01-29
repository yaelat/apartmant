using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using Solid.Core.Entities;
using Solid.Core.service;
using Solid.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apartmant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        
        private readonly ITransactionsService _transactionsService;
        // GET: api/<RecreationController>
        public TransactionsController(ITransactionsService transactionsService)
        {
            _transactionsService = transactionsService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_transactionsService.GetAllTransactions());
        }

        // GET api/<RecreationController>/5
        [HttpGet("{id}")]
        public Transactions Get(int id)
        {
            return _transactionsService.GetTransactionsById(id);
        }

        // POST api/<RecreationController>
        [HttpPost]
        public Transactions Post([FromBody] Transactions value)
        {
            return _transactionsService.PostTransactions(value);
        }

        // PUT api/<RecreationController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] transactions value)
        //{
        //    _transactionsService.PutRecreation(id, value);

        //}

        // DELETE api/<RecreationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _transactionsService.DeleteTransactions(id);
        }
    }
}
