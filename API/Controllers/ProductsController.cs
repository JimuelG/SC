using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductsController : BaseApiController
    {
        public ProductsController()
        {
        }

        [HttpGet]
        public string GetProduct()
        {
            return "Hello world";
        }
    }
}