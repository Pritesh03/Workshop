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
        if (!IsPostBack)
            UpdateWorkshopsGrid();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        tbl_Workshop workshop = new tbl_Workshop();
        workshop.WorkshopTitle = txtWorkshopTitle.Text;
        workshop.WorkshopDate = DateTime.Parse(txtWorkshopDate.Text);
        workshop.WorkshopDuration = txtWorkshopDuration.Text;
        workshop.WorkshopTopics = txtWorkshopTopics.Text;

        WorkshopBusiness workshopBusiness = new WorkshopBusiness();
        if (workshopBusiness.InsertWorkshop(workshop))
        {
            UpdateWorkshopsGrid();
            ClearInputs();
        }
        else
        {

        }
    }

    protected void gvWorkshops_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedRowWorkshopId = int.Parse(gvWorkshops.SelectedValue.ToString());

        WorkshopBusiness workshopBusiness = new WorkshopBusiness();
        tbl_Workshop workshop = workshopBusiness.GetWorkshopById(selectedRowWorkshopId);

        txtWorkshopTitle.Text = workshop.WorkshopTitle;
        txtWorkshopDate.Text = workshop.WorkshopDate.ToShortDateString();
        txtWorkshopDuration.Text = workshop.WorkshopDuration;
        txtWorkshopTopics.Text = workshop.WorkshopTopics;
    }

    private void UpdateWorkshopsGrid()
    {
        List<tbl_Workshop> lstWorkshops = new List<tbl_Workshop>();
        WorkshopBusiness workshopBusiness = new WorkshopBusiness();
        lstWorkshops = workshopBusiness.GetWorkshops();
        gvWorkshops.DataSource = lstWorkshops;
        gvWorkshops.DataBind();
    }

    private void ClearInputs()
    {
        txtWorkshopTitle.Text = string.Empty;
        txtWorkshopDate.Text = string.Empty;
        txtWorkshopDuration.Text = string.Empty;
        txtWorkshopTopics.Text = string.Empty;
    }


    protected void btnUpdate_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        WorkshopBusiness workshopBusiness = new WorkshopBusiness();
        int workshopId;
        if (int.TryParse(Convert.ToString(gvWorkshops.SelectedValue), out workshopId))
        {
            workshopBusiness.DeleteWorkshop(workshopId);
            UpdateWorkshopsGrid();
            ClearInputs();
        }
    }
}