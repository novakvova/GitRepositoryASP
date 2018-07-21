using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class WorkController : Controller
    {
        // GET: Work
        public ActionResult Index()
        {
            List<WorkItemViewModel> model = new List<WorkItemViewModel>();
            model.Add(new WorkItemViewModel
            {
                Id=1,
                Name="Semen"
            });
            model.Add(new WorkItemViewModel
            {
                Id = 2,
                Name = "Пилип"
            });
            //WorkItemViewModel model = new WorkItemViewModel();
            //model.Name = "Semen";
            //return View("Index", model);
            return View(model);
        }
    }
}