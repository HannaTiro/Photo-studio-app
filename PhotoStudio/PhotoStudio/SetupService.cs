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
            context.Database.Migrate();
        }
    }
}
