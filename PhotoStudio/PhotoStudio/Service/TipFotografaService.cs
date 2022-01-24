using AutoMapper;
using PhotoStudio.Data.Requests.TipFotografa;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class TipFotografaService : BaseService<Data.Model.TipFotografa, TipFotografaRequest, PhotoStudio.Database.TipFotografa>
    {
        public TipFotografaService(PhotoStudioContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Data.Model.TipFotografa> Get(TipFotografaRequest search = null)
        {
            var entity = _context.Set<Database.TipFotografa>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }
            if (search.TipFotografaId.HasValue)
            {
                entity = entity.Where(x => x.TipFotografaId == search.TipFotografaId);
            }
            var list = entity.ToList();
            return _mapper.Map<List<Data.Model.TipFotografa>>(list);
        }
    }
}
