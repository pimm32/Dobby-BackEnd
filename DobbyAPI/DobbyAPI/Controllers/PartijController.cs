using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DobbyAPI.Logic_Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using Newtonsoft.Json;

namespace DobbyAPI.Controllers
{
    [ApiController]
    public class PartijController : ControllerBase
    {

        [Route("Partij/VraagBordOp")]
        public string VraagBordOp()
        {
            Bord result = new Bord();
            string json = JsonConvert.SerializeObject(result.stelling, Formatting.Indented);



            return json;
        }
    }
}
