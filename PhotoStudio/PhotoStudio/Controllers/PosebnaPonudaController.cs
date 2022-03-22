using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Requests.PosebnaPonuda;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosebnaPonudaController : BaseCRUDController<Data.Model.PosebnaPonuda, PosebnaPonudaSearchRequest, PosebnaPonudaUpsert, PosebnaPonudaUpsert>
    {
       
        public PosebnaPonudaController(ICRUDService<Data.Model.PosebnaPonuda, PosebnaPonudaSearchRequest, PosebnaPonudaUpsert, PosebnaPonudaUpsert> service) : base(service)
        {

        }
    }
}
