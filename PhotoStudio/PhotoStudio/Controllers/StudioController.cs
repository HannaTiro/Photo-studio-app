using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Requests.Studio;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudioController : BaseCRUDController<Data.Model.Studio,StudioSearchRequest,StudioUpsert,StudioUpsert>
    {
        public StudioController(ICRUDService<Data.Model.Studio, StudioSearchRequest, StudioUpsert, StudioUpsert> service) : base(service)
        {

        }
    }
}
