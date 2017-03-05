using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.Admin.Controllers
{
    public class UtilisateursController : Controller
    {
        // GET: Admin/Utilisateurs
        public ActionResult Index()
        {
            return Content("Utilisateurs");
        }
    }
}