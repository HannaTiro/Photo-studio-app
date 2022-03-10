using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Interface
{
    public interface ISlikaService
    {
        byte[] Slika(int Id);
    }
}
