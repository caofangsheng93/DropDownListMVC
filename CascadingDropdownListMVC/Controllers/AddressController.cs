using CascadingDropdownListMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingDropdownListMVC.Controllers
{
    public class AddressController : Controller
    {
        private IAddressRepository _repository;

        public AddressController() :this(new AddressRepository())
        { }

        public AddressController(IAddressRepository repository)
        {
            this._repository = repository;
        }

        // GET: Address
        public ActionResult Index()
        {
            AddressModel model = new AddressModel();
            model.AvailableCountries.Add(new SelectListItem
            {
                Text = "-Please select-",
                Value = "Selects Items"
            });
            var countries = _repository.GetAllCountries();
            foreach (var item in countries)
            {
                model.AvailableCountries.Add(new SelectListItem() 
                { 
                    Text = item.CountryName,
                    Value = item.ID.ToString() 
                });
            }

            return View(model);
        }

        [HttpGet]
        public JsonResult GetStatesByCountryID(string countryID)
        {
            if (string.IsNullOrEmpty(countryID))
            {
                throw new ArgumentNullException("countryID");
            }
            int id = 0;
            bool isValid= int.TryParse(countryID, out id);
            var states= _repository.GetAllStatesByCountryID(id);
            var result = (from s in states select new { Id = s.ID, StateName = s.StateName }).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);

        }
    }
}