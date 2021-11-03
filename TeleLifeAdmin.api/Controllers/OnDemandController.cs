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
            var guid = $"Response from Container for pacing to {onDemand.Value} {Guid.NewGuid().ToString()} ";

            
            return (IActionResult)Ok(guid);

        }

        [HttpPost]
        [Route("AutomatedContacts")]
        public async Task<IActionResult> AddAutomatedContactsValue([FromBody]int automatedContactAmount)
        {
            var guid = $"Response from Container for loading {automatedContactAmount} automated contacts {Guid.NewGuid().ToString()} ";

            return (IActionResult)Ok(guid);

        }
    }
}
