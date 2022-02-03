using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoStudio.Data.Requests.Komentar;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class KomentarService:BaseCRUDService<Data.Model.Komentar,KomentarSearchRequest, Database.Komentar,KomentarUpsert,KomentarUpsert>
    {
        public KomentarService(PhotoStudioContext context, IMapper mapper): base(context,mapper)
        {

        }
        public override List<Data.Model.Komentar> Get(KomentarSearchRequest search = null)
        {
            var query = _context.Komentars.Include(x => x.Korisnik).Include(x => x.Fotograf).AsQueryable();

            if(search?.KorisnikId.HasValue==true)
            {
                query = query.Where(j => j.Korisnik.KorisnikId == search.KorisnikId);
            }
            if (search?.FotografId.HasValue == true)
            {
                query = query.Where(j => j.Fotograf.FotografId == search.FotografId);
            }

            if (!string.IsNullOrEmpty(search.ImeKorisnika))
            {
                query = query.Where(j => j.Korisnik.Ime.StartsWith(search.ImeKorisnika));
            }
            if (!string.IsNullOrEmpty(search.PrezimeKorisnika))
            {
                query = query.Where(j => j.Korisnik.Prezime.StartsWith(search.PrezimeKorisnika));
            }
          
            return _mapper.Map<List<Data.Model.Komentar>>(query.ToList());
        }
       
    }
}
