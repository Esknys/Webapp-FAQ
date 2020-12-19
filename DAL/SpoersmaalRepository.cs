using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oppgave3.Models;

namespace Oppgave3.DAL
{
    public class SpoersmaalRepository : ISpoersmaalRepository
    {
        private readonly SpoersmaalContext _db;

        public SpoersmaalRepository(SpoersmaalContext db)
        {
            _db = db;
        }

        public async Task<List<Spoersmaal>> HentAlle()
        {
            try
            {
                List<Spoersmaal> alleSpoersmaal = await _db.Spoersmaalene.Select(s => new Spoersmaal
                {
                    Id = s.Id,
                    Spoersmaalet = s.Spoersmaalet,
                    Svar = s.Svar
                }).ToListAsync();
                return alleSpoersmaal;
            }
            catch
            {
                return null;
            }
        }


    }

}