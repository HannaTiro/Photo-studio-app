using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Requests.Usluga;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UslugaController : BaseCRUDController<Data.Model.Usluga, UslugaSearchRequest, UslugaUpsert, UslugaUpsert>
    {
        public UslugaController(ICRUDService<Data.Model.Usluga, UslugaSearchRequest, UslugaUpsert, UslugaUpsert> service) : base(service)
        {

        }
       
       
    }
}
