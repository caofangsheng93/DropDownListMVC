using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingDropdownListMVC.Models
{
    public class AddressRepository : IAddressRepository
    {
        private AddressDataContext _dataContext;

        /// <summary>
        /// 手动写无参的构造函数
        /// </summary>
        public AddressRepository()
        {
            _dataContext = new AddressDataContext();
        }
        public IList<Country> GetAllCountries()
        {
            var query = from countries in _dataContext.Country select countries;
            var content = query.ToList();
            return content;
            //throw new NotImplementedException();  
        }

        public IList<State> GetAllStatesByCountryID(int countryID)
        {
            var query = from states in _dataContext.State where states.CountryId == countryID select states;
            var content = query.ToList();
            return content;

            //throw new NotImplementedException();
        }
    }
}