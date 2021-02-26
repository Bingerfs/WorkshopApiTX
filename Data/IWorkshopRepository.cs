using System;
using System.Collections.Generic;
using Data.entities;

namespace Data
{
    public interface IWorkshopRepository
    {
        List<WorkshopEntity> GetAllWorkshops();
        WorkshopEntity CreateWorkshop(WorkshopEntity entity);
        WorkshopEntity DeleteWorkshop(int id);
        WorkshopEntity UpdateWorkshop(WorkshopEntity entity);
        WorkshopEntity ChangeWorkshopStatus(int id, string status);
        
    }
}