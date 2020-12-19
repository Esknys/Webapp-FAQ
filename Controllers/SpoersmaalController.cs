using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oppgave3.DAL;
using System.Linq;
using Oppgave3.Models;
using Spoersmaal = Oppgave3.Models.Spoersmaal;

namespace Oppgave3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpoersmaalController : ControllerBase
    {
        private readonly Oppgave3.DAL.ISpoersmaalRepository _db;

        public SpoersmaalController(ISpoersmaalRepository db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task <List<Spoersmaal>> HentAlle()
        {
            return await _db.HentAlle();
        }

    }
}


       
    
