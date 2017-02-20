using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace app.com.Data
{
    public interface ICusRepository
    {
        IEnumerable<SelectListItem> GetCountries();
        DateTime GetCurrentDateTime();
        app_cus_main GetCustomers(int? id);
        string GetLoginUser();
    }
}