using Microsoft.AspNetCore.Mvc;
using Solid.Core.service;
using Solid.Core.Entities;
using Solid.Api.Models;
using AutoMapper;
using Solid.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apartmant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICustomersService _customersService;
        // GET: api/<RecreationController>
        public CustomersController(ICustomersService customerService,IMapper mapper)
        {
            _customersService = customerService;
            _mapper = mapper;
        }

        // GET: api/<RentingController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var customer = await _customersService.GetAllCustomersAsync();
            var customerDto = _mapper.Map<CustomerDto>(customer);
            return Ok(customerDto);
        }

        // GET api/<RentingController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var customers = await _customersService.GetAllCustomersAsync();
            var customerDto = _mapper.Map<IEnumerable <CustomerDto>>(customers);
            return Ok(customerDto);
            return Ok(_customersService.GetCustomerByIdAsync(id));
        }

        // POST api/<RentingController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CustomerPostModel customerPostModel)
        {
            var customer = _mapper.Map<Customer>(customerPostModel);
            var newCustomer=await _customersService.PostCustomerAsync(customer);
            var customerDto = _mapper.Map<CustomerDto>(newCustomer);
            return Ok(customerDto);
        }

        // PUT api/<RentingController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] CustomerPostModel customerPostModel)
        {
            var customer = _mapper.Map<Customer>(customerPostModel);
            await _customersService.PutCustomerAsync(id, customer);
        }

        // DELETE api/<RentingController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _customersService.DeleteCustomerAsync(id);
        }
    }
}