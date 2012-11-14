using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarkMockMvc.Controllers
{
    public class ServicesController : Controller
    {
        //
        // GET: /Services/CatchAll

        [HttpPost]
        public JsonResult CatchAll()
        {
            return Json(new { Prop1 = "Glenn", Prop2 = "Ferrie" });
        }

        
    }
}
