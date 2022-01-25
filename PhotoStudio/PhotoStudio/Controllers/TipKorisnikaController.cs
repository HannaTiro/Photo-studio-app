using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.TipKorisnika;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    public class TipKorisnikaController : BaseController<Data.Model.TipKorisnika, Data.Requests.TipKorisnika.TipKorisnikaRequest>
    {
        public TipKorisnikaController(IService<TipKorisnika, TipKorisnikaRequest> service) : base(service)
        {

        }
    }
}
