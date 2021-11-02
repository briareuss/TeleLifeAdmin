using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TeleLifeAdmin.shared.Models;

namespace TeleLifeAdmin.api.Controllers
{
    [ApiController]
    [Route("api/OnDemand/Values")]    
    public class OnDemandController : ControllerBase
    {

        [HttpPut]
        [Route("Pacing")]
        public async Task<IActionResult> ChangePacingValue(OnDemandConfiguration onDemand)
        {
            var guid = Guid.NewGuid().ToString();
            return (IActionResult)Ok(guid);

        }
    }
}
