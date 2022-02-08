using Microsoft.EntityFrameworkCore;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio
{
    public class SetupService
    {
        public static void Seed(PhotoStudioContext context)
        {
            // context.Database.Migrate();
            //context.Database.EnsureCreated();
            //This method does not use migrations to create the database. In addition, the database that is created cannot later be 
            //    updated using migrations.If you are targeting a relational database and using migrations, you can use the 
            //    DbContext.Database.Migrate() method to ensure the database is created and all migrations are applied.


        }
    }
}
