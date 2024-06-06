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
    public partial class InsertSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageSupplement.aspx");
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            String name = TboxName.Text;
            if (!SupplementController.validateName(name))
            {
                ErrorMsg.Text = "harus contain supplement";
                return;
            }
            DateTime expiry = Convert.ToDateTime(TboxExpiry.Text);
            if (!SupplementController.validateExpiry(expiry))
            {
                ErrorMsg.Text = "expiry date harus lebih dari hari ini";
                return;
            }
            int price = Convert.ToInt32(TboxPrice.Text);
            if(!SupplementController.validatePPrice(price))
            {
                ErrorMsg.Text = "price harus diatas 3000";
                return;
            }
            if (!SupplementController.isEmpty(TboxTypeId.Text))
            {
                ErrorMsg.Text = "type id tidak boleh kosong";
                return;
            }
            int typeId = Convert.ToInt32(TboxTypeId.Text);
            
            ErrorMsg.Text = SupplementController.insertSupplement(name, expiry, price, typeId);
        }
    }
}