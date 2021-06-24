using Microsoft.AspNetCore.Mvc;
using System;
using TeleLifeAdmin.api.Managers;

namespace TeleLifeAdmin.api.Controllers
{
    [ApiController]
    [Route("api/Dashboard")]
    public class DashboardController : ControllerBase
    {
        private IDashboardManager _dashboardManager;

        public DashboardController(IDashboardManager dashboardManager)
        {
            _dashboardManager = dashboardManager;
        }

        [HttpGet]
        [Route("Values")]
        public IActionResult Get()
        {
            try
            {
                var dashboardValues = _dashboardManager.RetrieveDashboardValues();

                if (dashboardValues == null)
                {
                    return NotFound();
                }
                return Ok(dashboardValues);
            }
            catch (Exception e)
            {
                return StatusCode(500);

            }
        }

        //[HttpGet]
        //[Route("CallResolution/Values")]
        //public IActionResult GetCallResolutions()
        //{
        //    try
        //    {
        //        var completionCodes = _dashboardDataAccess.RetrieveCompletionCodes(0);

        //        if (completionCodes == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(completionCodes);
        //    }
        //    catch (Exception e)
        //    {
        //        return StatusCode(500);

        //    }
        //}
    }
}
