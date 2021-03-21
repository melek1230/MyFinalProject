using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productservice;
     
        public ProductsController(IProductService productservice)
        {
            _productservice = productservice;

        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _productservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Product product)
        {
            var result = _productservice.Add(product);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _productservice.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetByCategory")]
        public IActionResult GetByCategoryId(int id)
        {
            var result = _productservice.GetAllByCategoryId(id);
            if(result.Success)
            {
                return Ok(result);
            }return BadRequest(result);
        }
    }
}
