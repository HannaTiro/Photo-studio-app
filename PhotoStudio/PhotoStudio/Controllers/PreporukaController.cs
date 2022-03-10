using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Requests.Recommend;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreporukaController : ControllerBase
    {
        private readonly IPreporukaService _service;
        public PreporukaController(IPreporukaService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Data.Model.Fotograf> RecommendF([FromQuery] RecommendSearchRequest request)
        {
            return _service.RecommendFotograf(request.FotografId);
        }
    }
}
