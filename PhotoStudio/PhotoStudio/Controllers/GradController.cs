using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Grad;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    public class GradController : BaseController<Data.Model.Grad,Data.Requests.Grad.GradSearchRequest>
    {
        public GradController(IService<Grad,GradSearchRequest>service):base(service)
        {

        }
    }
}
