using System;
using System.Collections.Generic;
using System.Linq;
using Data.entities;


namespace Data
{
    public class WorkshopRepository:IWorkshopRepository
    {
         private static List<WorkshopEntity> workshops = Enumerable.Range(1, 5).Select(index => new WorkshopEntity
            {
                Id = index,
                Status = "Scheduled",
                Name = "Taller bases"
            }).ToList();
        public List<WorkshopEntity> GetAllWorkshops()
        {
            return workshops;
        }

        public WorkshopEntity CreateWorkshop(WorkshopEntity entity)
        {
            entity.Id = workshops.Count + 1;
            workshops.Add(entity);
            return entity;
        }

        public WorkshopEntity DeleteWorkshop(int id)
        {
            WorkshopEntity entity = workshops.Find(workshop => workshop.Id == id);
            workshops.RemoveAll(workshop => workshop.Id == id);
            return entity;
        }
    }
}