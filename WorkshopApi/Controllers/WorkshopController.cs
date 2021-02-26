using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessLogic.models;
using BusinessLogic;

namespace ApiWorkshop.Controllers
{
    [ApiController]
    [Route("api/workshops")]
    public class WorkshopController : ControllerBase
    {
        

        private readonly ILogger<WorkshopController> _logger;

        private IWorkshopManager _workshopManager;

        public WorkshopController(ILogger<WorkshopController> logger, IWorkshopManager workshopManager)
        {
            _logger = logger;
            _workshopManager = workshopManager;
        }

        [HttpGet]
        public IEnumerable<Workshop> GetAllWorkshops()
        {
            return _workshopManager.GetAllWorkshops();
        }
    }
}