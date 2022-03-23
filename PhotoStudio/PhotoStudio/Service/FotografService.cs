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
            var entity = _context.Set<Database.Fotograf>().Include(x=>x.TipFotografa).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                entity = entity.Where(x => x.Ime.Equals(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                entity = entity.Where(x => x.Prezime.Equals(search.Prezime));
            }
            if(!string.IsNullOrWhiteSpace(search.TipFotografa))
            {
                entity = entity.Where(x => x.TipFotografa.Naziv.StartsWith(search.TipFotografa));
            }
         

            var list = entity.ToList();
            return _mapper.Map<List<Data.Model.Fotograf>>(list);
        }
        public override Data.Model.Fotograf GetByID(int id)
        {
            var fotograf = _context.Fotografs.Include(x => x.TipFotografa).FirstOrDefault(y => y.FotografId == id);
            return _mapper.Map<Data.Model.Fotograf>(fotograf);
        }

    }
}
