using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using Solid.Api.Models;
using Solid.Core.DTOs;
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
        private readonly IMapper _mapper;
        private readonly ITransactionsService _transactionsService;
        // GET: api/<RecreationController>
        public TransactionsController(ITransactionsService transactionsService,IMapper mapper)
        {
            _transactionsService = transactionsService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var transactions = await _transactionsService.GetAllTransactionsAsync();
            var transactionsDto = _mapper.Map<IEnumerable<TransactionDto>>(transactions);
            return Ok(transactionsDto);
        }

        // GET api/<RecreationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var transaction = await _transactionsService.GetTransactionsByIdAsync(id);
            var transactionDto = _mapper.Map<TransactionDto>(transaction);
            return Ok(transactionDto);
        }

        // POST api/<RecreationController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TransactionPostModel transactionPostModel)
        {
            var transaction = _mapper.Map<Transactions>(transactionPostModel);
            var newTransaction = await _transactionsService.PostTransactionsAsync(transaction);
            var transactionDto = _mapper.Map<TransactionDto>(newTransaction);
            return Ok(transactionDto);
        }

        // PUT api/<RecreationController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] transactions value)
        //{
        //    _transactionsService.PutRecreation(id, value);

        //}

        // DELETE api/<RecreationController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _transactionsService.DeleteTransactionsAsync(id);
        }
    }
}
