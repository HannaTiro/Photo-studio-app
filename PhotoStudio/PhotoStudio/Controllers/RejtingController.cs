using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Requests.Rejting;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RejtingController : BaseCRUDController<Data.Model.Rejting,RejtingSearchRequest,RejtingUpsert,RejtingUpsert>
    {
        public RejtingController(ICRUDService<Data.Model.Rejting,RejtingSearchRequest,RejtingUpsert,RejtingUpsert> service):base (service)
        {

        }
    }
}
