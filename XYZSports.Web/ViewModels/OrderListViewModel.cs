using XYZSports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XYZSports.Web.ViewModels
{
    public class OrderListViewModel
    {
        public IList<Order> Orders { get; set; }
    }
}
