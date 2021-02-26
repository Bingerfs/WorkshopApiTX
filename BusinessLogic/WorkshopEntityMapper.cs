using System;
using System.Collections.Generic;
using BusinessLogic.models;
using Data;
using Data.entities;

namespace BusinessLogic
{
    public class WorkshopEntityMapper
    {
        public Workshop EntityToWorkshop(WorkshopEntity entity)
        {
            Workshop workshop = new Workshop();
            workshop.Id = entity.Id;
            workshop.Name = entity.Name;
            workshop.Status = entity.Status;
            return workshop;
        }

        public WorkshopEntity WorkshopToEntity(Workshop workshop)
        {
            WorkshopEntity entity = new WorkshopEntity();
            entity.Id = workshop.Id;
            entity.Name = workshop.Name;
            entity.Status = workshop.Status;
            return entity;
        }
    }
}