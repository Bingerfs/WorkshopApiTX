using System;
using System.Linq;
using System.Collections.Generic;
using BusinessLogic.models;
using Data;
using Data.entities;


namespace BusinessLogic
{
    public class WorkshopManager:IWorkshopManager
    {
        private IWorkshopRepository _workshopRepository;

        public WorkshopManager(IWorkshopRepository workshopRepository)
        {
            _workshopRepository = workshopRepository;
        }
        public List<Workshop> GetAllWorkshops()
        {
            WorkshopEntityMapper mapper = new WorkshopEntityMapper();
            List<Workshop> workshopsList = _workshopRepository.GetAllWorkshops().Select(entity => mapper.EntityToWorkshop(entity)).ToList();
            return workshopsList;
        }

        public Workshop CreateWorkshop(Workshop workshop)
        {
            WorkshopEntityMapper mapper = new WorkshopEntityMapper();
            WorkshopEntity entity = mapper.WorkshopToEntity(workshop);
            Workshop createdWorkshop = mapper.EntityToWorkshop(_workshopRepository.CreateWorkshop(entity));
            return createdWorkshop;
        }

        public Workshop DeleteWorkshop(int id)
        {
            WorkshopEntityMapper mapper = new WorkshopEntityMapper();
            Workshop deletedWorkshop = mapper.EntityToWorkshop(_workshopRepository.DeleteWorkshop(id));
            return deletedWorkshop;
        }
    }
}