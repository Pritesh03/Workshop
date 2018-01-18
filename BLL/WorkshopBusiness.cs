using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class WorkshopBusiness
    {
        //Insert record in database.
        public bool InsertWorkshop(tbl_Workshop workshop)
        {
            if(workshop.WorkshopDate > DateTime.Now)
            {
                WorkshopDB workshopDB = new WorkshopDB();
                if (workshopDB.InsertIntoDB(workshop))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }                
        }

        //Get all records from database.
        public List<tbl_Workshop> GetWorkshops()
        {
            WorkshopDB workshopDB = new WorkshopDB();
            return workshopDB.GetWorkshops();
        }

        //Get a perticular workshop by id
        public tbl_Workshop GetWorkshopById(int? workshopId)
        {
            WorkshopDB workshopDB = new WorkshopDB();
            return workshopDB.GetWorkshopById(workshopId);
        }

        //Delete record from database
        public bool DeleteWorkshop(int? workshopId)
        {
            WorkshopDB workshopDB = new WorkshopDB();
            return workshopDB.DeleteWorkshop(workshopId);
        }
    }
}
