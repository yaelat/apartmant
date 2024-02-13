using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.Api.Models;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apartmant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleAndRentingController : ControllerBase
    {
        private readonly ISaleAndRentingService _saleAndRentingService;
        private readonly IMapper _mapper;
        // GET: api/<RecreationController>
        public SaleAndRentingController(ISaleAndRentingService saleAndRentingService,IMapper mapper)
        {
            _saleAndRentingService = saleAndRentingService;
            _mapper = mapper;
        }
        // GET: api/<SaleController>
        [HttpGet]
        public ActionResult Get()
        {
            var apartmants = _saleAndRentingService.GetAllSaleAndRenting();
            var apartmantsDto=_mapper.Map<IEnumerable<SaleAndRantingDto>>(apartmants);
            return Ok(apartmantsDto);
        }

        // GET api/<SaleController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var apartmant = _saleAndRentingService.GetSaleAndRentingById(id);
            var apartmantDto = _mapper.Map<SaleAndRantingDto>(apartmant);
            return Ok(apartmantDto);
        }

        // POST api/<SaleController>
        [HttpPost]
        public ActionResult Post([FromBody] SaleAndRentingPostModel saleAndRentingPostModel)
        {
            var saleAndRenting = _mapper.Map<SaleAndRenting>(saleAndRentingPostModel);
            var newSaleAndRenting=_saleAndRentingService.PostSaleAndRenting(saleAndRenting);
            var saleAndRentingDto = _mapper.Map<SaleAndRantingDto>(newSaleAndRenting);
            return Ok(saleAndRentingDto);
        }

        // PUT api/<SaleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SaleAndRentingPostModel saleAndRentingPostModel)
        {
            var saleAndRenting = _mapper.Map<SaleAndRenting>(saleAndRentingPostModel);
            _saleAndRentingService.PutSaleAndRanting(id, saleAndRenting);
        }

        // DELETE api/<SaleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _saleAndRentingService.DeleteSaleAndRenting(id);
        }
    }
}
