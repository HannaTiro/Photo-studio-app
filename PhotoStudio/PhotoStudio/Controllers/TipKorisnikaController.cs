using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Model;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    public class TipKorisnikaController : BaseController<Data.Model.TipKorisnika,object>
    {
        public TipKorisnikaController(IService<TipKorisnika,object> service):base (service)
        {

        }
    }
}
