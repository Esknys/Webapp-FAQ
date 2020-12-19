using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oppgave3.Models;

namespace Oppgave3.DAL
{
    public class InnSpoersmaalRepository : IInnSpoersmaalRepository
    {
        private readonly SpoersmaalContext _db;

        public InnSpoersmaalRepository(SpoersmaalContext db)
        {
            _db = db;
        }

        public async Task<bool> Lagre(InnSpoersmaal innSpoersmaal)
        {
            try
            {
                var nyInnSpoersmaal = new InnSpoersmaalene();
                nyInnSpoersmaal.Id = innSpoersmaal.Id;
                nyInnSpoersmaal.Spoersmaalet = innSpoersmaal.Spoersmaalet;
                nyInnSpoersmaal.Navn = innSpoersmaal.Navn;
                nyInnSpoersmaal.Epost = innSpoersmaal.Epost;
                _db.InnSpoersmaalene.Add(nyInnSpoersmaal);
                await _db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Task<bool> Lagre()
        {
            throw new NotImplementedException();
        }
    }
}
