using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oppgave3.Models;

namespace Oppgave3.DAL
{
    public interface IInnSpoersmaalRepository
    {

        Task<bool> Lagre(InnSpoersmaal innSpoersmaal);

    }
}
