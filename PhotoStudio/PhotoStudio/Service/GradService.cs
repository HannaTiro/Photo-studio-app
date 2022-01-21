using AutoMapper;
using PhotoStudio.Data.Requests.Grad;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class GradService:BaseService<Data.Model.Grad,GradSearchRequest,PhotoStudio.Database.Grad>
    {
        public GradService(PhotoStudioContext context,IMapper mapper): base(context,mapper)
        {

        }
    }
}
