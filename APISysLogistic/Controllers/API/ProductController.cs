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
        public List<RegisteredProduct> List()
        {
            return this._productService.List();
        }
    }
}
