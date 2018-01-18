using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;
using BLL;

public partial class Admin_Workshop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<tbl_Workshop> lstWorkshops = new List<tbl_Workshop>();
        WorkshopBusiness workshopBusiness = new WorkshopBusiness();        
        lstWorkshops = workshopBusiness.GetWorkshops();
        gvWorkshops.DataSource = lstWorkshops;
        gvWorkshops.DataBind();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        tbl_Workshop workshop = new tbl_Workshop();
        workshop.WorkshopTitle = txtWorkshopTitle.Text;
        workshop.WorkshopDate = DateTime.Parse(txtWorkshopDate.Text);
        workshop.WorkshopDuration = txtWorkshopDuration.Text;
        workshop.WorkshopTopics = txtWorkshopTopics.Text;

        WorkshopBusiness workshopBusiness = new WorkshopBusiness();
        if(workshopBusiness.InsertWorkshop(workshop))
        {

        }
        else
        {

        }
    }
}