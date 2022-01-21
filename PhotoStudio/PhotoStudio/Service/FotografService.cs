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
       
    }
}
