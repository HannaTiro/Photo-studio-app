using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCRUDController<TModel, Tsearch, TInsert, TUpdate> : BaseController<TModel, Tsearch> where Tsearch:class
    {
        protected readonly ICRUDService<TModel, Tsearch, TInsert, TUpdate> _service = null;

        public BaseCRUDController(ICRUDService<TModel, Tsearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public TModel Insert(TInsert request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public TModel Update (int id,TUpdate request)
        {
            return _service.Update(id, request);
        }
        [HttpDelete]
       void Delete (int id)
        {
            _service.Delete(id);
        }
    }
}
