using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Interfaces.Declarations;
using Services.Interfaces.Responses;
using Services.Interfaces.Requests;
using Services.Implementation.SQL;
namespace SysLogistic.Controllers
{
    public class MovementController : Controller
    {
        private IProductService _productService;
        private IMovementService _movementService;
        private IMovementTypeService _movementTypeService;
        private IWarehouseService _warehouseService;

        public MovementController()
        {
            _productService = new ProductServiceSQL();
            _movementService = new MovementServiceSQL();
            _movementTypeService = new MovementTypeServiceSQL();
            _warehouseService = new WarehouseServiceSQL();
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
        [HttpGet]
        public ActionResult ListWarehouses()
        {
            var list = _warehouseService.List();
            return Json(new { count = list.Count, data = list }, JsonRequestBehavior.AllowGet);
        }

        public RegisteredMovement Create(CreateMovement createMovement)
        {
            return _movementService.Create(createMovement);
        }
    }
}