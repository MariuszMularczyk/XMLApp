using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using XMLApp.Application;
using XMLApp.Data;
using XMLApp.Dictionaries;

namespace XMLApp.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("add")]
        public void Add([FromForm]ProductAddVM model)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(model);
            }
        }

        [HttpGet("getProducts")]
        public List<ProductListDTO> GetProducts()
        {
            return _productService.GetProducts();
        }

        [HttpGet("getProduct/{id}")]
        public ProductEditVM GetProduct(int id)
        {
            return _productService.GetProduct(id);
        }
        [HttpPost("edit")]
        public void Edit(ProductEditVM model)
        {
            _productService.Edit(model);
        }

        [HttpDelete("deleteProduct/{id}")]
        public void Delete(int id)
        {
            _productService.Delete(id);
        }


    }
}
