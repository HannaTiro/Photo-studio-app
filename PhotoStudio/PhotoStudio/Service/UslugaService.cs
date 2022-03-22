using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoStudio.Data.Requests.Usluga;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class UslugaService : BaseCRUDService<Data.Model.Usluga, UslugaSearchRequest, Database.Usluga, UslugaUpsert, UslugaUpsert>
    {
        public UslugaService(PhotoStudioContext context, IMapper mapper) : base(context, mapper)
        {


        }
        public override List<Data.Model.Usluga> Get(UslugaSearchRequest request)
        {
            var query = _context.Usluga.Include(x => x.Studio).AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }
            if (!string.IsNullOrWhiteSpace(request.Studio))
            {
                query = query.Where(x => x.Studio.NazivStudija.StartsWith(request.Studio));
            }
          


            var list = query.ToList();
            return _mapper.Map<List<Data.Model.Usluga>>(list);
        }
    }
}
