using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonInformationApp.Models;

namespace PersonInformationApp.Controllers
{
    public class PersonController : Controller
    {
        // GET: PersonController
        public ActionResult Index()
        {
            return View();
        }



        // GET: PersonController/Create
        public ActionResult Create()
        {
            PersonModel model = new PersonModel();

            return View(model);
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonModel data)
        {
            try
            {
                return View(data);
            }
            catch
            {
                return View();
            }
        }

    }
}
