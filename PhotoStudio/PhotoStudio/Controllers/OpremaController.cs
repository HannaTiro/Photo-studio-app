using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Requests.Oprema;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpremaController : BaseCRUDController<Data.Model.Oprema, OpremaSearchRequest, OpremaUpsert, OpremaUpsert>
    {
        public OpremaController(ICRUDService<Data.Model.Oprema, OpremaSearchRequest, OpremaUpsert, OpremaUpsert> service) : base(service)
        {

        }
    }
}
