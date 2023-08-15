using Microsoft.AspNetCore.Mvc;
using PersonInformationApp.Models;

namespace PersonInformationApp.Controllers
{
    public class AddressController1 : Controller
    {

        private readonly ILogger<AddressController1> _logger;

        public AddressController1(ILogger<AddressController1> logger)
        {
            _logger = logger;
        }


        // GET: Addres
        public IActionResult Index()
        {
            return View();
        }

        // GET: AddressController/Create
        public ActionResult Create()
        {
            AddressModel addressModel = new AddressModel();
            return View(addressModel);
        }

        // POST: AddressController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel model)
        {

            

            if(ModelState.IsValid == false)
            {
                _logger.LogWarning("The user submitted an invalid address upon creation");
                return View();
            }

            try
            {
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }
    }
}
