using System;
using System.Web.Mvc;
using MvcFlash.Core;
using MvcFlash.Core.Extensions;
using SoftwareTest.Helpers;
using SoftwareTest.Models.ViewModels;

namespace SoftwareTest.Controllers
{
    public class LinkedListController : Controller
    {
        public ActionResult Index()
        {
            return View(new LinkedListFormViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LinkedListFormViewModel formModel)
        {
            var linkedListInt = new LinkedList<int>();
            linkedListInt.AddToLinkedList(4);
            linkedListInt.AddToLinkedList(5);
            linkedListInt.AddToLinkedList(7);
            linkedListInt.AddToLinkedList(2);
            linkedListInt.AddToLinkedList(1);
            linkedListInt.AddToLinkedList(10);

            var linkedListString = new LinkedList<string>();
            linkedListString.AddToLinkedList("Mike");
            linkedListString.AddToLinkedList("Williams");
            linkedListString.AddToLinkedList("is");
            linkedListString.AddToLinkedList("a");
            linkedListString.AddToLinkedList("nice");
            linkedListString.AddToLinkedList("guy");

            try
            {
                var nThElementInt = LinkedListHelper.GetElementAt(linkedListInt, formModel.Index);
                var nThElementString = LinkedListHelper.GetElementAt(linkedListString, formModel.Index);

                Flash.Instance.Success(
                    string.Format("Index: {0} - Element in the int linked list is \"{1}\" and \"{2}\" in the string linked list",
                        formModel.Index, nThElementInt, nThElementString));
            }
            catch (Exception exception)
            {
                Flash.Instance.Error(exception.Message);
            }

            return View(formModel);
        }
    }
}