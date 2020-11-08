using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using XYZSports.Models;
using System.Threading.Tasks;
using XYZSports.DAL.Test;
using XYZSports.DAL;

namespace HPlusSports.DAL.Test
{
    [TestClass]
    public class TrackingRepositoryTests
    {
        [TestMethod]
        public async Task DeletedEntityIsMarkedAndNotRemoved()
        {
            using (var context = Helpers.GetContext("DeletedEntity"))
            {
                context.Add(new Salesperson() { Id = 1, Deleted = false });
                await context.SaveChangesAsync();
                var repo = new TrackingRepository<Salesperson>(context);

                await repo.Delete(1);
                await repo.SaveChanges();
            }

            using (var context = Helpers.GetContext("DeletedEntity"))
            {
                var person = context.Find<Salesperson>(1);
                Assert.IsTrue(person.Deleted, "The person should be marked deleted");
            }
        }

        
    }
}
