using System;
using System.Collections.Generic;
using BusinessLogic.models;

namespace BusinessLogic
{
    public interface IWorkshopManager
    {
        List<Workshop> GetAllWorkshops();
        Workshop CreateWorkshop(Workshop workshop);
        Workshop DeleteWorkshop(int id);
        Workshop UpdateWorkshop(Workshop workshop);

    }
    
}