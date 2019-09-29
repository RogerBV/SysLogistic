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
    public class ProductController : Controller
    {
        private ICategoryService _categoryService;
        private IProductService _productService;

        public ProductController()
        {
            _categoryService = new CategoryServiceSQL();
            _productService = new ProductServiceSQL();
        }
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public RegisteredProduct Create(CreateProduct newProduct)
        {
            newProduct.CreationDate = DateTime.Now;
            return this._productService.Create(newProduct);
        }
        [HttpPost]
        public RegisteredProduct Update(UpdateProduct registeredProduct)
        {
            registeredProduct.CreateDate = DateTime.Now;
            return this._productService.Update(registeredProduct);
        }

        [HttpGet]
        public ActionResult ListCategories()
        {
            List<RegisteredCategory> list = this._categoryService.List();
            return Json(new { count = list.Count, data = list }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult List()
        {
            List<RegisteredProduct> list = this._productService.List();
            return Json(new { count = list.Count, data = list }, JsonRequestBehavior.AllowGet);
        }
    }
}























































