using BLL.Abstract;
using BLL.Services;
using BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class DepatrmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepatrmentController()
        {
            _departmentService = new DepartmentService();
        }
        // GET: Work
        public ActionResult Index()
        {
            var model = _departmentService.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(DepartmentAddViewModel model)
        {
            _departmentService.Add(model);
            return RedirectToAction("Index");
        }
    }
}