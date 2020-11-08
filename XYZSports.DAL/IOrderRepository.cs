using System.Collections.Generic;
using System.Threading.Tasks;
using XYZSports.Models;

namespace XYZSports.DAL
{
    public interface IOrderRepository
    {
        Order Create(NewOrderInformation orderInfo);
        Task<List<Order>> GetByCustomerPartialLastName(string lastName);
    }
}