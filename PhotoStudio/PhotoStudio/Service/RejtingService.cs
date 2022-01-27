using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoStudio.Data.Requests.Rejting;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class RejtingService:BaseCRUDService<Data.Model.Rejting,RejtingSearchRequest,Database.Rejting,RejtingUpsert,RejtingUpsert>
    {
        public RejtingService(PhotoStudioContext context, IMapper mapper): base(context,mapper)
        {

        }
        public override List<Data.Model.Rejting> Get(RejtingSearchRequest search = null)
        {
            //  var query = _context.Rejtings.Include(i => i.Korisnik).Include(i => i.Fotograf).AsQueryable();
            var query = _context.Set<Database.Rejting>()
              .Include(x => x.Korisnik)
              .Include(e => e.Fotograf)
              .AsQueryable();
          


            if (search?.Ocjena.HasValue == true)
            {
                query = query.Where(i => i.Ocjena == search.Ocjena);
            }
            if (!string.IsNullOrWhiteSpace(search.Ime))
            {
                query = query.Where(i => i.Korisnik.Ime.StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search.Prezime))
            {
                query = query.Where(i => i.Korisnik.Prezime.StartsWith(search.Prezime));
            }
            if (search?.KorisnikId.HasValue == true)
            {
                query = query.Where(i => i.Korisnik.KorisnikId == search.KorisnikId);
            }
            if (search?.FotografId.HasValue == true)
            {
                query = query.Where(i => i.Fotograf.FotografId == search.FotografId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Data.Model.Rejting>>(list);


        }
        public override Data.Model.Rejting GetByID(int id)
        {
            var entity = _context.Rejtings.Include(x => x.Korisnik).Include(x => x.Fotograf).FirstOrDefault(x => x.RejtingId == id);
            return _mapper.Map<Data.Model.Rejting>(entity);
        }

    }
}
