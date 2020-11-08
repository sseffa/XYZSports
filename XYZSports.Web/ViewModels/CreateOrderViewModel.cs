using XYZSports.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XYZSports.Web.ViewModels
{
    public class CreateOrderViewModel
    {
        public List<SelectListItem> Products { get; set; }
        public List<string> SelectedProductCodes { get; set; }
        public List<SelectListItem> Customers { get; set; }
        public int CustomerId { get; set; }
        public List<SelectListItem> SalesPeople { get; set; }
        public int SalesPersonId { get; set; }
        
    }
}
