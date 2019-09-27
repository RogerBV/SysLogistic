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
        [HttpPost]
        public RegisteredCategory Create(CreateCategory newCategory)
        {
            newCategory.CreationDate = DateTime.Now;
            return this._categoryService.Create(newCategory);
        }

        [HttpPost]
        public RegisteredCategory Update(UpdateCategory updateCategory)
        {
            updateCategory.CreationDate = DateTime.Now;
            return this._categoryService.Update(updateCategory);
        }

        [HttpGet]
        public ActionResult List()
        {
            List<RegisteredCategory> list = this._categoryService.List();

            return Json(new { count = list.Count,data = list }, JsonRequestBehavior.AllowGet);
        }
    }
}