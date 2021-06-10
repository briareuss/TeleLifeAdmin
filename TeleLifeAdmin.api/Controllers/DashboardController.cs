using Microsoft.AspNetCore.Mvc;
using System;
using TeleLifeAdmin.api.DataAccess;

namespace TeleLifeAdmin.api.Controllers
{
    [ApiController]
    [Route("api/Dashboard")]
    public class DashboardController : ControllerBase
    {
        private IDashboardDataAccess _dashboardDataAccess;

        public DashboardController(IDashboardDataAccess dashboardDataAccess)
        {
            _dashboardDataAccess = dashboardDataAccess;
        }

        [HttpGet]
        [Route("Values")]
        public IActionResult Get()
        {
            try
            {
                var dashboardValues = _dashboardDataAccess.RetrieveDashboardData();

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

        [HttpGet]
        [Route("CallResolution/Values")]
        public IActionResult GetCallResolutions()
        {
            try
            {
                var completionCodes = _dashboardDataAccess.RetrieveCompletionCodes(0);

                if (completionCodes == null)
                {
                    return NotFound();
                }
                return Ok(completionCodes);
            }
            catch (Exception e)
            {
                return StatusCode(500);

            }
        }
    }
}
