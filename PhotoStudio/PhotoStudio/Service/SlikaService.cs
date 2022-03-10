using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoStudio.Database;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class SlikaService : ISlikaService
    {
        protected readonly PhotoStudioContext _context;
        protected readonly IMapper _mapper;

        public SlikaService(PhotoStudioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public byte[] Slika(int Id)
        {
            return _context.Fotografs.Find(Id).Slika;
        }

    }
}
