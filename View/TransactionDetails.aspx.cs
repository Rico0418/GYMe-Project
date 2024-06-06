using Project1._0.Controller;
using Project1._0.Model;
using Project1._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1._0.View
{
    public partial class TransactionDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int id = Convert.ToInt32(Request["Id"]);
                TransactionDetail td = TransactionController.getTransactionDetailById(id);
                lblSupplementID.Text = "Supplement ID:" + td.SupplementID.ToString();
                lblSupplementName.Text = "Supplement Name: "+ SupplementController.getSupplementName(td.SupplementID); //sudah diganti
                lblQuantity.Text = "Quantity: " + td.Quantity.ToString();


            }
        }
    }
}