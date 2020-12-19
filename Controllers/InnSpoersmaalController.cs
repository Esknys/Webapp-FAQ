using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oppgave3.DAL;
using Oppgave3.Models;

namespace Oppgave3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InnSpoersmaalController : ControllerBase
    {
        private readonly IInnSpoersmaalRepository _db;

    public InnSpoersmaalController(IInnSpoersmaalRepository db)
    {
        _db = db;
    }
        [HttpPost]
    public async Task<bool> Lagre([FromBody]InnSpoersmaal innSpoersmaal)
    {
        return await _db.Lagre(innSpoersmaal);
    }
        
    }
}