using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace XYZSports.DAL.Test
{
    public static class Helpers
    {
        public static AppDbContext GetContext(string name)
        {
            var dbOptions = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(name).Options;
            return new AppDbContext(dbOptions);
        }
    }
}
