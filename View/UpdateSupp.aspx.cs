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
    public partial class UpdateSupp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request["Id"]);
                MsSupplement supplement = SupplementRepository.getSupplementById(id);
                TboxName.Text =supplement.SupplementName;
                TboxExpiry.Text = Convert.ToString(supplement.SupplementExpiryDate);
                TboxPrice.Text = Convert.ToString(supplement.SupplementPrice);
                TboxTypeId.Text = Convert.ToString(supplement.SupplementTypeID);
            }
        }


        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageSupplement.aspx");
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["Id"]);
            String name;
            DateTime expiryDate;
            int price;
            if( !SupplementController.isEmpty(TboxName.Text))
            {
                ErrorMsg.Text = "Name harus tidak boleh kosong";
                return;
            }
            else
            {
                if(!SupplementController.validateName(TboxName.Text))
                {
                    ErrorMsg.Text = "nama haru contain Supplement";
                    return;
                }
                name = TboxName.Text;
            }
            if(!SupplementController.isEmpty(TboxExpiry.Text))
            {
                ErrorMsg.Text = "expired tidak boleh kosong";
                return;
            }
            else
            {
                
                if (!SupplementController.validateExpiry(DateTime.Parse(TboxExpiry.Text)))
                {
                    ErrorMsg.Text = "expired harus lebih dari hari ini";
                    return;
                }
                expiryDate = DateTime.Parse(TboxExpiry.Text);
            }
            if (!SupplementController.isEmpty(TboxPrice.Text))
            {
                ErrorMsg.Text = "Price harus diisi";
                return;
            }
            else
            {
                price = Convert.ToInt32(TboxPrice.Text);
                if (!SupplementController.validatePPrice(price))
                {
                    ErrorMsg.Text = "price harus diatas 3000";
                    return;
                }

            }
            if (!SupplementController.isEmpty(TboxTypeId.Text))
            {
                ErrorMsg.Text = "type id tidak boleh kosong";
                return;
            }
            int typeID = Convert.ToInt32(TboxTypeId.Text);
            if(expiryDate == null && price.Equals(null))
            {
                ErrorMsg.Text = "isi date dan price kosong";
                return;
            }
            ErrorMsg.Text = SupplementController.UpdateSupplement(id, name, expiryDate, price, typeID);
            

        }
    }
}