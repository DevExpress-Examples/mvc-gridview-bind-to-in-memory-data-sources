using System;
using System.Web.Mvc;
using CS.Models;

namespace CS.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        /*DataTable*/
        public ActionResult DataTableDataBinding() {
            if(Session["DataTableModel"] == null)
                Session["DataTableModel"] = InMemoryModel.GetDataTableModel();

            return View(Session["DataTableModel"]);
        }
        public ActionResult DataTableDataBindingPartial() {
            return PartialView(Session["DataTableModel"]);
        }
        /**/

        /*Typed List*/
        public ActionResult TypedListDataBinding() {
            if(Session["TypedListModel"] == null)
                Session["TypedListModel"] = InMemoryModel.GetTypedListModel();

            return View(Session["TypedListModel"]);
        }
        public ActionResult TypedListDataBindingPartial() {
            return PartialView(Session["TypedListModel"]);
        }
        /**/
    }
}