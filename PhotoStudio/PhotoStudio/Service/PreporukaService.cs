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
    public class PreporukaService:IPreporukaService
    {
        protected readonly PhotoStudioContext _context;
        protected readonly IMapper _mapper;

        public PreporukaService(PhotoStudioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        Dictionary<int, List<Database.Rejting>> ocjene = new Dictionary<int, List<Database.Rejting>>();

        public List<Data.Model.Fotograf> RecommendFotograf(int fotografId)
        {
            var f = LoadSlicne(fotografId);
            return _mapper.Map<List<Data.Model.Fotograf>>(f);
        }
        private List<Database.Fotograf> LoadSlicne(int fotografId)
        {
            LoadRazlicite(fotografId);
            List<Database.Rejting> ocjeneFotografa = _context.Rejtings.Where(e => e.FotografId == fotografId).OrderBy(e => e.KorisnikId).ToList();

            List<Database.Rejting> ocjene1 = new List<Database.Rejting>();
            List<Database.Rejting> ocjene2 = new List<Database.Rejting>();
            List<Database.Fotograf> preporukaFotografa = new List<Database.Fotograf>();

            foreach (var item in ocjene)
            {
                foreach (Database.Rejting ocjena in ocjeneFotografa)
                {
                    if (item.Value.Where(x => x.KorisnikId == ocjena.KorisnikId).Count() > 0)
                    {
                        ocjene1.Add(ocjena);
                        ocjene2.Add(item.Value.Where(x => x.KorisnikId == ocjena.KorisnikId).First());
                    }
                }
                double similarity = GetSlicne(ocjene1, ocjene2);
                if (similarity > 0.5)
                {
                    preporukaFotografa.Add(_context.Fotografs.Where(x => x.FotografId == item.Key)
                        .Include(x => x.TipFotografa)
                        .FirstOrDefault());
                }
                ocjene1.Clear();
                ocjene2.Clear();
            }
            return preporukaFotografa;
        }
        private double GetSlicne(List<Database.Rejting> ocjene1, List<Database.Rejting> ocjene2)
        {
            if (ocjene1.Count != ocjene2.Count)
            {
                return 0;
            }

            double x = 0, y1 = 0, y2 = 0;
            for (int i = 0; i < ocjene1.Count; i++)
            {
                x += ocjene1[i].Ocjena * ocjene2[i].Ocjena;
                y1 += ocjene1[i].Ocjena * ocjene1[i].Ocjena;
                y2 += ocjene2[i].Ocjena * ocjene2[i].Ocjena;
            }
            y1 = Math.Sqrt(y1);
            y2 = Math.Sqrt(y2);

            double y = y1 * y2;
            if (y == 0)
                return 0;
            return x / y;
        }
        private void LoadRazlicite(int fotografId)
        {
            List<Database.Fotograf> listFotografa = _context.Fotografs.Where(e => e.FotografId != fotografId).ToList();
            List<Database.Rejting> listaRejting = new List<Database.Rejting>();
            foreach (var item in listFotografa)
            {
                listaRejting = _context.Rejtings.Where(e => e.FotografId == item.FotografId).OrderBy(e => e.KorisnikId).ToList();
                if (listaRejting.Count > 0)
                    ocjene.Add(item.FotografId, listaRejting);
            }
        }
    }
}
