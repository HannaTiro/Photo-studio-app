using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoStudio.Data.Requests.Korisnik;
using PhotoStudio.Database;
using PhotoStudio.Helper;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class KorisnikService : IKorisnikService
    {
        protected readonly PhotoStudioContext _context;
        protected readonly IMapper _mapper;
        public KorisnikService(PhotoStudioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Data.Model.Korisnik> Get(KorisnikSearchRequest request)
        {
            var query = _context.Korisniks.Include(x=>x.Grad).AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }
            if (!string.IsNullOrWhiteSpace(request.Telefon))
            {
                query = query.Where(x => x.Telefon.Contains(request.Telefon));
            }
            if (!string.IsNullOrWhiteSpace(request.Username))
            {
                query = query.Where(x => x.Username == request.Username);
            }
            if (!string.IsNullOrWhiteSpace(request.Email))
            {
                query = query.Where(x => x.Email.StartsWith(request.Email));
            }

            var list = query.ToList();
            return _mapper.Map<List<Data.Model.Korisnik>>(list);
        }
        public Data.Model.Korisnik GetById(int id)
        {
            var korisnik = _context.Korisniks.Include(x => x.Grad).FirstOrDefault(y => y.KorisnikId == id);
            return _mapper.Map<Data.Model.Korisnik>(korisnik);
        }
        public Data.Model.Korisnik Insert(KorisnikUpsert request)
        {
            var entity = _mapper.Map<Korisnik>(request);

            if (request.Password != request.PasswordConfirm)
            {
                throw new Exception("Password i potvrda passworda nisu iste");
            }
            entity.PasswordSalt = HashGenerator.GenerateSalt();
            entity.PasswordHash = HashGenerator.GenerateHash(entity.PasswordSalt, request.Password);

            _context.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Data.Model.Korisnik>(entity);
        }
        public Data.Model.Korisnik Update(int id, KorisnikUpsert request)
        {
            var entity = _context.Korisniks.Find(id);

            _context.Korisniks.Attach(entity);
            _context.Korisniks.Update(entity);

            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<Data.Model.Korisnik>(entity);
        }
    }
}
