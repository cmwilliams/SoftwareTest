using System;
using System.IO;
using System.Web.Mvc;
using MvcFlash.Core;
using MvcFlash.Core.Extensions;
using SoftwareTest.Helpers;
using SoftwareTest.Models.ViewModels;

namespace SoftwareTest.Controllers
{
    public class PrimeFactorController : Controller
    {
        public ActionResult Index()
        {
            return View(new PrimeFactorFormViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(PrimeFactorFormViewModel formModel)
        {
            if (formModel.TextFile != null && formModel.TextFile.ContentLength > 0)
                try
                {
                    var fileName = formModel.TextFile.FileName;
                    if (fileName != null)
                    {
                        var path = Path.Combine(Server.MapPath("~/Files"), Path.GetFileName(fileName));
                        formModel.TextFile.SaveAs(path);
                        formModel.PrimeFactors = PrimeFactorHelper.GetPrimeFactors(path);
                    }
                }
                catch (Exception exception)
                {
                    Flash.Instance.Error(exception.Message);
                }
            else
            {
                Flash.Instance.Error("You have not specified a file.");
            }
            return View(formModel);
        }
    }
}