using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoStudio.Data.Requests.PosebnaPonuda;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class PosebnaPonudaService: BaseCRUDService<Data.Model.PosebnaPonuda, PosebnaPonudaSearchRequest, Database.PosebnaPonuda, PosebnaPonudaUpsert, PosebnaPonudaUpsert>
    {
        public PosebnaPonudaService(PhotoStudioContext context, IMapper mapper) : base(context, mapper)
        {


        }
        public override List<Data.Model.PosebnaPonuda> Get(PosebnaPonudaSearchRequest request)
        {
            var query = _context.PosebnaPonuda.Include(x => x.Studio).AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.NazivPonude))
            {
                query = query.Where(x => x.NazivPonude.Equals(request.NazivPonude));
            }
            if (!string.IsNullOrWhiteSpace(request.Opis))
            {
                query = query.Where(x => x.Opis.Contains(request.Opis));
            }
            
            if (!string.IsNullOrWhiteSpace(request.Studio))
            {
                query = query.Where(x => x.Studio.NazivStudija.StartsWith(request.Studio));
            }

            var list = query.ToList();
            return _mapper.Map<List<Data.Model.PosebnaPonuda>>(list);
        }
    }
}
