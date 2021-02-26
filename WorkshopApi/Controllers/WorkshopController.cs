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

        [HttpPost]
        public Workshop CreateAWorkshop(Workshop workshop)
        {
            return _workshopManager.CreateWorkshop(workshop);
        }

         [HttpDelete("{id}")]
        public Workshop DeleteWorkshop(int id)
        {
            return _workshopManager.DeleteWorkshop(id);
        }

        [HttpPut("{id}")]
        public Workshop UpdateWorkshop(int id, Workshop workshop)
        {
            workshop.Id = id;
            return _workshopManager.UpdateWorkshop(workshop);
        }

        [HttpPatch("{id}/cancel-workshop")]
        public Workshop CancelWorkshop(int id)
        {
            return _workshopManager.ChangeWorkshopStatus(id, "Cancelled");
        }
    }
}