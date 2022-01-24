using AutoMapper;
using PhotoStudio.Data.Requests.Grad;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class GradService:BaseService<Data.Model.Grad,GradSearchRequest,PhotoStudio.Database.Grad>
    {
        public GradService(PhotoStudioContext context,IMapper mapper): base(context,mapper)
        {

        }
        public override List<Data.Model.Grad> Get(GradSearchRequest search = null)
        {
            var entity = _context.Set<Database.Grad>().AsQueryable();
            if(!string.IsNullOrWhiteSpace(search?.NazivGrada))
            {
                entity = entity.Where(x => x.NazivGrada.Contains(search.NazivGrada));
            }
            if(search.GradId.HasValue)
            {
                entity = entity.Where(x => x.GradId == search.GradId);
            }
            var list = entity.ToList();
            return _mapper.Map<List<Data.Model.Grad>>(list);
            
        }
    }
}
