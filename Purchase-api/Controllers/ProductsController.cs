using Microsoft.AspNetCore.Mvc;
using PurchaseApi.Services;
using System;
using System.Xml.Linq;

namespace PurchaseApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController(IDataProviderService dataProviderService) : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return dataProviderService.GetProducts();
        }

        [HttpGet("{index}")]
        public string Get(int index)
        {
            return dataProviderService.GetProduct(index);
        }

        [HttpPost]
        public string Create([FromBody] string name)
        {
            return dataProviderService.CreateProduct(name);
        }

        [HttpPut("{index}")]
        public string Update(int index, string name)
        {
            return dataProviderService.UpdateProduct(index, name);
        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            dataProviderService.DeleteProduct(index);
        }
    }
}