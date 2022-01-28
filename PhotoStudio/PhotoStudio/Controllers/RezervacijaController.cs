using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Requests.Rezervacija;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    public class RezervacijaController : BaseCRUDController<Data.Model.Rezervacija,RezervacijaSearchRequest,RezervacijaUpsert,RezervacijaUpsert>
    {
        public RezervacijaController(ICRUDService<Data.Model.Rezervacija,RezervacijaSearchRequest,RezervacijaUpsert,RezervacijaUpsert> service):base (service)
        {

        }
    }
}
