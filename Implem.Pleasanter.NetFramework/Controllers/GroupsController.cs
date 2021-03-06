﻿using Implem.Pleasanter.NetFramework.Libraries.Requests;
using System.Web.Mvc;
namespace Implem.Pleasanter.NetFramework.Controllers
{
    [Authorize]
    [ValidateInput(false)]
    public class GroupsController : Controller
    {
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult Index()
        {
            var context = new ContextImplement();
            var controller = new Implem.Pleasanter.Controllers.GroupsController();
            var htmlOrJson = controller.Index(context: context);
            if (!Request.IsAjaxRequest())
            {
                ViewBag.HtmlBody = htmlOrJson;
                return View();
            }
            else
            {
                return Content(htmlOrJson);
            }
        }

        [HttpGet]
        public ActionResult New(long id = 0)
        {
            var context = new ContextImplement();
            var controller = new Implem.Pleasanter.Controllers.GroupsController();
            var html = controller.New(context: context, id: id);
            ViewBag.HtmlBody = html;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult Edit(int id)
        {
            var context = new ContextImplement();
            var controller = new Implem.Pleasanter.Controllers.GroupsController();
            var htmlOrJson = controller.Edit(context: context, id: id);
            if (!Request.IsAjaxRequest())
            {
                ViewBag.HtmlBody = htmlOrJson;
                return View();
            }
            else
            {
                return Content(htmlOrJson);
            }
        }

        [HttpPost]
        public string GridRows()
        {
            var context = new ContextImplement();
            var controller = new Implem.Pleasanter.Controllers.GroupsController();
            var json = controller.GridRows(context: context);
            return json;
        }

        [HttpPost]
        public string Create()
        {
            var context = new ContextImplement();
            var controller = new Implem.Pleasanter.Controllers.GroupsController();
            var json = controller.Create(context: context);
            return json;
        }

        [HttpPut]
        public string Update(int id)
        {
            var context = new ContextImplement();
            var controller = new Implem.Pleasanter.Controllers.GroupsController();
            var json = controller.Update(context: context, id: id);
            return json;
        }

        [HttpDelete]
        public string Delete(int id)
        {
            var context = new ContextImplement();
            var controller = new Implem.Pleasanter.Controllers.GroupsController();
            var json = controller.Delete(context: context, id: id);
            return json;
        }

        [HttpDelete]
        public string DeleteComment(int id)
        {
            var context = new ContextImplement();
            var controller = new Implem.Pleasanter.Controllers.GroupsController();
            var json = controller.DeleteComment(context: context, id: id);
            return json;
        }

        [HttpPost]
        public string Histories(int id)
        {
            var context = new ContextImplement();
            var controller = new Implem.Pleasanter.Controllers.GroupsController();
            var json = controller.Histories(context: context, id: id);
            return json;
        }

        [HttpPost]
        public string History(int id)
        {
            var context = new ContextImplement();
            var controller = new Implem.Pleasanter.Controllers.GroupsController();
            var json = controller.History(context: context, id: id);
            return json;
        }

        [HttpPost]
        public string SelectableMembers(int id)
        {
            var context = new ContextImplement();
            var controller = new Implem.Pleasanter.Controllers.GroupsController();
            var json = controller.SelectableMembers(context: context, id: id);
            return json;
        }
    }
}
