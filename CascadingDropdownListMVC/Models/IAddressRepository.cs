using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CascadingDropdownListMVC.Models
{
   public interface IAddressRepository
    {
        IList<Country> GetAllCountries();
        IList<State> GetAllStatesByCountryID(int countryID);
    }
}
