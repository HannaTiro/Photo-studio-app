using Microsoft.AspNetCore.Mvc;
using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Interface
{
    public interface IKorisnikService
    {
        List<Data.Model.Korisnik> Get(KorisnikSearchRequest request);
        List<Data.Model.Korisnik> GetRegistracija(KorisnikSearchRequest request);
        Data.Model.Korisnik GetById(int id);
        Data.Model.Korisnik Insert(KorisnikUpsert request);
        Data.Model.Korisnik Update(int id, KorisnikUpsert request);

    Task<Data.Model.Korisnik> Login(KorisnikLoginRequest request);
        ActionResult<Korisnik> SignUp(KorisnikUpsert request);
    }
}
