using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoStudio.Data.Requests.Novost;
using PhotoStudio.Database;
using PhotoStudio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Service
{
    public class NovostService : BaseCRUDService<Data.Model.Novost, NovostSearchRequest, Database.Novost, NovostUpsert, NovostUpsert>
    {
       
        public NovostService(PhotoStudioContext context, IMapper mapper) : base(context, mapper)
        {
            
            
        }

       public override List<Data.Model.Novost> Get(NovostSearchRequest request)
        {
            var query = _context.Novost.Include(x => x.Studio).AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.Naslov))
            {
                query = query.Where(x => x.Naslov.Contains(request.Naslov));
            }
            if (!string.IsNullOrWhiteSpace(request.Sadrzaj))
            {
                query = query.Where(x => x.Sadrzaj.Contains(request.Sadrzaj));
            }
            if (!string.IsNullOrWhiteSpace(request.DatumObjave))
            {
                query = query.Where(x => x.DatumObjave.ToString().StartsWith(request.DatumObjave));
            }
           
            var list = query.ToList();
            return _mapper.Map<List<Data.Model.Novost>>(list);
        }

  
      
    }
}
