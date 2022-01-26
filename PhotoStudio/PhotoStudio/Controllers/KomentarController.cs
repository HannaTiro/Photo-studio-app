using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Requests.Komentar;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KomentarController : BaseCRUDController<Data.Model.Komentar,KomentarSearchRequest,KomentarUpsert,KomentarUpsert>
    {
        public KomentarController(ICRUDService<Data.Model.Komentar,KomentarSearchRequest,KomentarUpsert,KomentarUpsert> service): base(service)
        {

        }
    }
}
