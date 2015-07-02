using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T4Sample.ViewModels.User;

namespace T4Sample.Controllers
{
    public partial class UserController : Controller
    {
        [HttpGet]
        public virtual ActionResult Details(int id, string name)
        {
            UserDetailsVM model = new UserDetailsVM()
            {
                UserID = id,
                Name = name ?? "Test Name"
            };
            return View(MVC.User.Views.ViewNames.Details);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Details(UserDetailsVM model)
        {
            return RedirectToAction("Details", new { id = model.UserID, name = model.Name });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult T4Details(UserDetailsVM model)
        {
            return RedirectToAction(MVC.User.Details(model.UserID, model.Name));
        }
    }
}