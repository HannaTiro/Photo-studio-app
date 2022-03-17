using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Korisnik;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]

    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikService _service;

        public KorisnikController(IKorisnikService service)
        {
            _service = service;
        }
        [Authorize]
        [HttpGet]
        

        public ActionResult<List<Data.Model.Korisnik>> Get([FromQuery] KorisnikSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{registracija}")]
        public ActionResult<List<Data.Model.Korisnik>> GetRegistracija([FromQuery] KorisnikSearchRequest request)
        {
            return _service.GetRegistracija(request);
        }


        [HttpGet("{id}")]
        public ActionResult<Data.Model.Korisnik> GetById(int id)
        {
            return _service.GetById(id);
        }


        [HttpPost]
        public ActionResult<Data.Model.Korisnik> Insert(KorisnikUpsert request)
        {
            return _service.Insert(request);
        }
        
        [HttpPut("{id}")]
        public ActionResult<Data.Model.Korisnik> Update(int id, [FromBody] KorisnikUpsert request)
        {
            return _service.Update(id, request);
        }

    }
}
