using Medfar.Interview.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Medfar.Interview.Types;
using Medfar.Interview.DAL.Repositories;

namespace Medfar.Interview.Web.Controllers
{
    public class ExamController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            user.id = Guid.NewGuid();
            user.date_created = DateTime.Now;
            UserRepository userinsert = new UserRepository();
            userinsert.Insert(user);

            //shuffle for fun
           

            return View();

        }
    }
}