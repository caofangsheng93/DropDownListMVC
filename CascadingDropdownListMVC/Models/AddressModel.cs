using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingDropdownListMVC.Models
{
    public class AddressModel
    {
        public AddressModel()
        {
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
        }
        [Display(Name = "Country")]
        public int CountryID { get; set; }

        public IList<SelectListItem> AvailableCountries { get; set; }

        [Display(Name = "State")]
        public int StateID { get; set; }

        public IList<SelectListItem> AvailableStates { get; set; }
    }
}