using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oppgave3.Models;

namespace Oppgave3.DAL
{
    public interface ISpoersmaalRepository
    {

        Task<List<Spoersmaal>> HentAlle();

    }
}
