using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using Services.Interfaces.Declarations;
using Services.Implementation.SQL;
namespace SysLogistic.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController() {
            _categoryService = new CategoryServiceSQL();
        }
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public RegisteredCategory Create(CreateCategory newCategory)
        {
            return this._categoryService.Create(newCategory);
        }
    }
}