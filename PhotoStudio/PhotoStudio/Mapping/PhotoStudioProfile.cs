using AutoMapper;
using Microsoft.Azure.Amqp.Framing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Mapping
{
    public class PhotoStudioProfile: Profile
    {
        public PhotoStudioProfile()
        {
            CreateMap<PhotoStudio.Database.Korisnik,PhotoStudio.Data.Model.Korisnik>().ReverseMap();
            CreateMap<PhotoStudio.Database.TipKorisnika, Data.Model.TipKorisnika>().ReverseMap();
            CreateMap<PhotoStudio.Database.Studio, Data.Model.Studio>().ReverseMap();
            CreateMap<PhotoStudio.Database.Fotograf, Data.Model.Fotograf>().ReverseMap();
            CreateMap<PhotoStudio.Database.TipFotografa, Data.Model.TipFotografa>().ReverseMap();
            CreateMap<PhotoStudio.Database.Grad, Data.Model.Grad>().ReverseMap();
            CreateMap<PhotoStudio.Database.Komentar, Data.Model.Komentar>().ReverseMap();
            CreateMap<PhotoStudio.Database.Rejting, Data.Model.Rejting>().ReverseMap();
            CreateMap<PhotoStudio.Database.Rezervacija, Data.Model.Rezervacija>().ReverseMap();



        }
    }
}
