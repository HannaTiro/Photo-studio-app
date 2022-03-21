using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Requests.Novost;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NovostController : BaseCRUDController<Data.Model.Novost, NovostSearchRequest, NovostUpsert, NovostUpsert>
    {
        public NovostController(ICRUDService<Data.Model.Novost, NovostSearchRequest, NovostUpsert, NovostUpsert> service) : base(service)
        {

        }
    }
}
