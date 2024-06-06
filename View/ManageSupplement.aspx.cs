using Project1._0.Controller;
using Project1._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1._0.View
{
    public partial class ManageSupplement : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshGrid();
            }
        }
        private void RefreshGrid()
        {
            gvSupplements.DataSource = SupplementController.getAllSupplements();
            gvSupplements.DataBind();
        }


        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertSupplement.aspx");
        }

        protected void gvSupplements_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvSupplements.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            ErrorMsg.Text = SupplementController.DeleteSupplement(id);
            RefreshGrid();
        }




        protected void gvSupplements_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvSupplements.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("UpdateSupp.aspx?Id=" + id);
        }
    }
}