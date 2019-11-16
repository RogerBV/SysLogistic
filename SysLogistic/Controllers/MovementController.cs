using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Interfaces.Declarations;
using Services.Implementation.SQL;
namespace SysLogistic.Controllers
{
    public class MovementController : Controller
    {
        private IProductService _productService;
        private IMovementService _movementService;
        private IMovementTypeService _movementTypeService;

        public MovementController()
        {
            _productService = new ProductServiceSQL();
            _movementService = new MovementServiceSQL();
            _movementTypeService = new MovementTypeServiceSQL();
        }

        // GET: Movement
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ListMovementTypes()
        {
            var list = _movementTypeService.List();
            return Json(new { count = list.Count, data = list }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult ListProducts()
        {
            var list = _productService.List();
            return Json( new { count = list.Count, data = list },JsonRequestBehavior.AllowGet);
        }
    }
}