using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaludMental.Controllers
{
    public class PrimeraNecesidad : Controller
    {
        // GET: PrimeraNecesidad
        public ActionResult Index()
        {
            return View();
        }

        // GET: PrimeraNecesidad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
