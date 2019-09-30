using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Implementation.SQL;
using Services.Interfaces.Declarations;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
namespace SysLogistic.Controllers
{
    public class WarehouseController : Controller
    {
        private IWarehouseService _warehouseService;

        public WarehouseController()
        {
            _warehouseService = new WarehouseServiceSQL();
        }
        // GET: Warehouse
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public RegisteredWarehouse Create(CreateWarehouse newWarehouse)
        {
            newWarehouse.CreationDate = DateTime.Now;
            return this._warehouseService.Create(newWarehouse);
        }
        [HttpPost]
        public RegisteredWarehouse Update(UpdatedWarehouse updatedWarehouse)
        {
            updatedWarehouse.CreateDate = DateTime.Now;
            return this._warehouseService.Update(updatedWarehouse);
        }

        [HttpGet]
        public ActionResult List()
        {
            List<RegisteredWarehouse> list = this._warehouseService.List();
            return Json(new { count = list.Count, data = list }, JsonRequestBehavior.AllowGet);
        }
        
    }
}
