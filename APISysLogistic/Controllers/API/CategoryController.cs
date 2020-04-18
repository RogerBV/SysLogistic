using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services.Interfaces.Declarations;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using Services.Implementation.SQL;
namespace APISysLogistic.Controllers.API
{
    public class CategoryController : ApiController
    {
        private ICategoryService _categoryService;
        public CategoryController()
        {
            _categoryService = new CategoryServiceSQL();
        }

        [HttpGet]
        public IHttpActionResult List()
        {
            return Ok(new { lstCategories = this._categoryService.List() });

        }
    }
}
