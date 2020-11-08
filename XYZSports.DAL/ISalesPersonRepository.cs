using System.Collections.Generic;
using System.Threading.Tasks;
using XYZSports.Models;

namespace XYZSports.DAL
{
    public interface ISalesPersonRepository : ITrackingRepository<Salesperson>
    {
        Task<List<Salesperson>> GetSalesPeopleByStateGroup(string state);
        Task<List<Salesperson>> GetWithOrders();
    }
}