using Project1._0.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1._0.View
{
    public partial class TransactionQueue : System.Web.UI.Page
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
            gvTransactions.DataSource = TransactionController.getAllTransactions();
            gvTransactions.DataBind();
        }
        protected void gvTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvTransactions.Rows[gvTransactions.SelectedIndex];
            int id = Convert.ToInt32(row.Cells[1].Text);
            Response.Redirect("TransactionDetails.aspx?Id=" + id);
        }

        protected void gvTransactions_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvTransactions.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("TransactionDetails.aspx?Id=" + id);
        }

        protected void gvTransactions_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvTransactions.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            ErrorMsg.Text = TransactionController.updateTransaction(id);
            RefreshGrid();
        }
    }
}