using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoStudio.Data.Requests.Studio;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class StudioService:BaseCRUDService<Data.Model.Studio,StudioSearchRequest,Database.Studio,StudioUpsert,StudioUpsert>
    {
        public StudioService(PhotoStudioContext context, IMapper mapper):base(context,mapper)
        {

        }
        public override List<Data.Model.Studio> Get(StudioSearchRequest search = null)
        {
            var query = _context.Set<Studio>().Include(x=>x.Grad).AsQueryable();
            if(!string.IsNullOrWhiteSpace(search.NazivStudija))
            {
                query = query.Where(x => x.NazivStudija.Contains(search.NazivStudija));
            }
            if(!string.IsNullOrWhiteSpace(search.Telefon))
            {
                query = query.Where(x => x.Telefon.StartsWith(search.Telefon));
            }
            if (!string.IsNullOrWhiteSpace(search.Adresa))
            {
                query = query.Where(x => x.Adresa.Contains(search.Adresa));
            }
            if (search?.GradId.HasValue==true)
            {
                query = query.Where(x => x.GradId==search.GradId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Data.Model.Studio>>(list);
        }
    }
}
