using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoStudio.Data.Requests.Oprema;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class OpremaService: BaseCRUDService<Data.Model.Oprema, OpremaSearchRequest, Database.Oprema, OpremaUpsert, OpremaUpsert>
    {
        public OpremaService(PhotoStudioContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Data.Model.Oprema> Get(OpremaSearchRequest request)
        {
            var query = _context.Oprema.Include(x => x.Studio).AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }
            if (!string.IsNullOrWhiteSpace(request.Opis))
            {
                query = query.Where(x => x.Opis.Contains(request.Opis));
            }
           
            if (!string.IsNullOrWhiteSpace(request.Studio))
            {
                query = query.Where(x => x.Studio.NazivStudija.Equals(request.Studio));
            }
            if (request.StudioId.HasValue)
            {
                query = query.Where(x => x.StudioId == request.StudioId);
            }

            var list = query.ToList();
            return _mapper.Map<List<Data.Model.Oprema>>(list);
        }
    }
}
