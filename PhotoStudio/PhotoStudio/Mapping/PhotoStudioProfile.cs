using AutoMapper;
using Microsoft.Azure.Amqp.Framing;
using PhotoStudio.Data.Requests.Fotograf;
using PhotoStudio.Data.Requests.Grad;
using PhotoStudio.Data.Requests.Komentar;
using PhotoStudio.Data.Requests.Korisnik;
using PhotoStudio.Data.Requests.Novost;
using PhotoStudio.Data.Requests.PosebnaPonuda;
using PhotoStudio.Data.Requests.Rejting;
using PhotoStudio.Data.Requests.Rezervacija;
using PhotoStudio.Data.Requests.Studio;
using PhotoStudio.Data.Requests.TipFotografa;
using PhotoStudio.Data.Requests.TipKorisnika;
using PhotoStudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Mapping
{
    public class PhotoStudioProfile : Profile
    {
        public PhotoStudioProfile()
        {
            CreateMap<PhotoStudio.Database.Korisnik, PhotoStudio.Data.Model.Korisnik>().ReverseMap();
            CreateMap<PhotoStudio.Database.TipKorisnika, Data.Model.TipKorisnika>().ReverseMap();
            CreateMap<PhotoStudio.Database.Studio, Data.Model.Studio>().ReverseMap();
            CreateMap<PhotoStudio.Database.Fotograf, Data.Model.Fotograf>().ReverseMap();
            CreateMap<PhotoStudio.Database.TipFotografa, Data.Model.TipFotografa>().ReverseMap();
            CreateMap<PhotoStudio.Database.Grad, Data.Model.Grad>().ReverseMap();
            CreateMap<PhotoStudio.Database.Komentar, Data.Model.Komentar>().ReverseMap();
            CreateMap<PhotoStudio.Database.Rejting, Data.Model.Rejting>().ReverseMap();
            CreateMap<PhotoStudio.Database.Rezervacija, Data.Model.Rezervacija>().ReverseMap();
            CreateMap<PhotoStudio.Database.Novost, Data.Model.Novost>().ReverseMap();
            CreateMap<PhotoStudio.Database.PosebnaPonuda, Data.Model.PosebnaPonuda>().ReverseMap();



            //Grad

            CreateMap<PhotoStudio.Database.Grad, GradRequest>().ReverseMap();
            CreateMap<PhotoStudio.Database.Grad, GradUpsert>().ReverseMap();
            CreateMap<PhotoStudio.Database.Grad, GradSearchRequest>().ReverseMap();

            //Fotograf
            CreateMap<FotografRequest, PhotoStudio.Database.Fotograf>().ReverseMap();
            CreateMap<FotografRequest, FotografUpsert>().ReverseMap();
            CreateMap<PhotoStudio.Database.Fotograf, FotografUpsert>().ReverseMap();

            //TipFotografa
            CreateMap<PhotoStudio.Database.TipFotografa, TipFotografaRequest>().ReverseMap();

            //TipKorisnika
            CreateMap<PhotoStudio.Database.TipKorisnika, TipKorisnikaRequest>().ReverseMap();

            //Korisnik
            CreateMap<KorisnikRequest, PhotoStudio.Database.Korisnik>().ReverseMap();
            CreateMap<KorisnikRequest, GradRequest>().ReverseMap();
            CreateMap<PhotoStudio.Database.Korisnik, KorisnikUpsert>().ReverseMap();

            //Komentar
            CreateMap<KomentarRequest, PhotoStudio.Database.Fotograf>().ReverseMap();
            CreateMap<KomentarRequest, FotografRequest>().ReverseMap();
            CreateMap<KomentarRequest, PhotoStudio.Database.Korisnik>().ReverseMap();
            CreateMap<Komentar, KomentarUpsert>().ReverseMap();
            CreateMap<KomentarRequest, PhotoStudio.Database.Komentar>().ReverseMap();

            //Rejting
            CreateMap<Rejting, RejtingRequest>().ReverseMap();
            CreateMap<Rejting, RejtingUpsert>().ReverseMap();

            CreateMap<RejtingRequest, Database.Korisnik>().ReverseMap();
            CreateMap<RejtingRequest, Database.Fotograf>().ReverseMap();

           CreateMap<RejtingRequest,FotografRequest>().ReverseMap();
           CreateMap<RejtingRequest, KorisnikRequest>().ReverseMap();

            //Studio
            CreateMap<Database.Studio, StudioRequest>().ReverseMap();
            CreateMap<Database.Studio, StudioUpsert>().ReverseMap();
            CreateMap<StudioRequest, StudioSearchRequest>().ReverseMap();


            //Rezervacija
            CreateMap<Rezervacija, RezervacijaUpsert>().ReverseMap();
            CreateMap<RezervacijaRequest, Database.Rezervacija>().ReverseMap();


            CreateMap<RezervacijaRequest, Database.Korisnik>().ReverseMap();
            CreateMap<RezervacijaRequest, Database.Fotograf>().ReverseMap();


            //Novost
            CreateMap<Novost, NovostUpsert>().ReverseMap();
            CreateMap<NovostRequest, NovostSearchRequest>().ReverseMap();
            CreateMap<Database.Novost, NovostRequest>().ReverseMap();


            //PosebnaPonuda
            CreateMap<PosebnaPonuda, PosebnaPonudaUpsert>().ReverseMap();
            CreateMap<PosebnaPonudaRequest, PosebnaPonudaSearchRequest>().ReverseMap();
            CreateMap<Database.PosebnaPonuda, PosebnaPonudaRequest>().ReverseMap();
























        }
    }
}
