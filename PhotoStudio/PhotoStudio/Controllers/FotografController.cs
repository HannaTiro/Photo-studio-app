using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Fotograf;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    public class FotografController : BaseCRUDController<Data.Model.Fotograf,FotografSearchRequest,FotografUpsert,FotografUpsert>
    {
        public FotografController(ICRUDService<Fotograf,FotografSearchRequest,FotografUpsert,FotografUpsert> service):base(service)
        {

        }
    }
}
