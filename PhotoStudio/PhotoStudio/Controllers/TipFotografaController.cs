using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Remoting;
using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.TipFotografa;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipFotografaController :  BaseController<Data.Model.TipFotografa, Data.Requests.TipFotografa.TipFotografaRequest>
    {
        public TipFotografaController(IService<TipFotografa, TipFotografaRequest> service) : base(service)
        {

        }
    }
}
