using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoStudio.Data.Requests.Fotograf;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class FotografService:BaseCRUDService<Data.Model.Fotograf,FotografSearchRequest,Fotograf,FotografUpsert,FotografUpsert>
    {
        public FotografService(PhotoStudioContext context, IMapper mapper):base(context,mapper)
        {

        }
        public override List<Data.Model.Fotograf> Get(FotografSearchRequest search = null)
        {
            var entity = _context.Set<Database.Fotograf>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                entity = entity.Where(x => x.Ime.Contains(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                entity = entity.Where(x => x.Prezime.Contains(search.Prezime));
            }
           // entity = entity.Include("TipFotografa");

            var list = entity.ToList();
            return _mapper.Map<List<Data.Model.Fotograf>>(list);
        }

    }
}
