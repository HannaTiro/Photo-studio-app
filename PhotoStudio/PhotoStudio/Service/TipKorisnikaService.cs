using AutoMapper;
using PhotoStudio.Data.Requests.TipKorisnika;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class TipKorisnikaService : BaseService<Data.Model.TipKorisnika, TipKorisnikaRequest, PhotoStudio.Database.TipKorisnika>
    {
        public TipKorisnikaService(PhotoStudioContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Data.Model.TipKorisnika> Get(TipKorisnikaRequest search = null)
        {
            var entity = _context.Set<Database.TipKorisnika>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Tip))
            {
                entity = entity.Where(x => x.Tip.Contains(search.Tip));
            }
            if (search.TipKorisnikaId.HasValue)
            {
                entity = entity.Where(x => x.TipKorisnikaId == search.TipKorisnikaId);
            }

            var list = entity.ToList();
            return _mapper.Map<List<Data.Model.TipKorisnika>>(list);
        }
    }
}
