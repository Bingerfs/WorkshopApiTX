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
    }
}