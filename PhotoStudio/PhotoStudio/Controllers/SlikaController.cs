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
    public class SlikaController : ControllerBase
    {
        private readonly ISlikaService _service;
        public SlikaController(ISlikaService service)
        {
            _service = service;
        }


        [HttpGet("{Id}")]
        public IActionResult Slika(int Id)
        {
            var slika = _service.Slika(Id);

            return File(slika, "image/jpeg");
        }

    }
}
