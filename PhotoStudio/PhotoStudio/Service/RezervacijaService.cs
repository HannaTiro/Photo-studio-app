using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoStudio.Data.Requests.Rezervacija;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class RezervacijaService : BaseCRUDService<Data.Model.Rezervacija, RezervacijaSearchRequest, Database.Rezervacija, RezervacijaUpsert, RezervacijaUpsert>
    {
        public RezervacijaService(PhotoStudioContext context, IMapper mapper):base(context,mapper)
        {

        }
        public override List<Data.Model.Rezervacija> Get(RezervacijaSearchRequest search = null)
        {
            var query = _context.Rezervacijas.Include(x => x.Fotograf).Include(x => x.Korisnik).AsQueryable();
            if(!string.IsNullOrEmpty(search.ImeFotografa))
            {
                query = query.Where(x => x.Fotograf.Ime.StartsWith(search.ImeFotografa));
            }
            if (search?.FotografId.HasValue == true)
            {
                query = query.Where(x => x.Fotograf.FotografId == search.FotografId);
            }
            if (!string.IsNullOrEmpty(search.ImeKorisnika))
            {
                query = query.Where(x => x.Korisnik.Ime.StartsWith(search.ImeKorisnika));
            }
            if (search?.KorisnikId.HasValue == true)
            {
                query = query.Where(x => x.Korisnik.KorisnikId == search.KorisnikId);
            }
            if (search.DatumOd!=null && search.DatumDo!=null)
            {
                var datumOd = search.DatumOd.Value.Date;
                var datumDo = search.DatumDo.Value.Date;
                query = query.Where(x => x.DatumOd.Value.Date >= datumOd && x.DatumDo.Value.Date <= datumDo);
            }
            var list = query.ToList();
            return _mapper.Map<List<Data.Model.Rezervacija>>(list);
           

        }
        public override Data.Model.Rezervacija GetByID(int id)
        {
            var entity = _context.Rezervacijas.Include(x => x.Fotograf).Include(x => x.Korisnik).FirstOrDefault(x => x.RezervacijaId == id);
            return _mapper.Map<Data.Model.Rezervacija>(entity);
        }
    }
}
