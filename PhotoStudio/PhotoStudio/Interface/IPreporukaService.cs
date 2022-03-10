using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Interface
{
    public interface IPreporukaService
    {
        List<Data.Model.Fotograf> RecommendFotograf(int fotografId);

    }
}
