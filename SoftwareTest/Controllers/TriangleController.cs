using System;
using System.Web.Mvc;
using MvcFlash.Core;
using MvcFlash.Core.Extensions;
using SoftwareTest.Helpers;
using SoftwareTest.Models.ViewModels;

namespace SoftwareTest.Controllers
{
    public class TriangleController : Controller
    {
        public ActionResult Index()
        {
            return View(new TriangleFormViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(TriangleFormViewModel formModel)
        {
            if (!ModelState.IsValid)
                return View(formModel);

            var triangleType = TriangleHelper.GetTriangleType(formModel.SideA, formModel.SideB, formModel.SideC);
            if (triangleType == TriangleType.Invalid)
            {
                Flash.Instance.Info("Triangle is invalid");
            }
            else
            {
                Flash.Instance.Success(string.Format("Triangle Type is {0}", Enum.GetName(typeof(TriangleType), triangleType)));
            }


            return View(new TriangleFormViewModel());
        }
    }
}