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

        public List<tbl_Workshop> GetWorkshops()
        {
            WorkshopDB workshopDB = new WorkshopDB();
            return workshopDB.GetWorkshops();
        }
    }
}
