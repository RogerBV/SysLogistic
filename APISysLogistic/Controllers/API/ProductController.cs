using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services.Implementation.SQL;
using Services.Interfaces.Declarations;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
namespace APISysLogistic.Controllers.API
{
    public class ProductController : ApiController
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public ProductController()
        {
            _productService = new ProductServiceSQL();
            _categoryService = new CategoryServiceSQL();
        }

        [HttpGet]
        public IHttpActionResult List()
        {
            return Ok(new { lstRegisteredProducts = this._productService.List() });
        }

        [HttpPost]
        public RegisteredProduct Create(string Name,string Description,  decimal Price,int CategoryId)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.Name = Name;
            createProduct.Description = Description;
            createProduct.Price = Price;
            createProduct.CategoryId = CategoryId;
            createProduct.CreationDate = DateTime.Now;
            return this._productService.Create(createProduct);
        }
    }
}
