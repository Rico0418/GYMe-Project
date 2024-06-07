using Project1._0.Dataset;
using Project1._0.Handler;
using Project1._0.Model;
using Project1._0.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1._0.View
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet data = getData(TransactionHandler.getAllTransactions());
            report.SetDataSource(data);
        }

        private DataSet getData(List<TransactionHeader> transaction)
        {
            DataSet dataSet = new DataSet();
            var headerTable = dataSet.TransactionHeader;
            var detailTable = dataSet.TransactionDetail;
            foreach (TransactionHeader t in transaction)
            {
                int total = 0;
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                hrow["Status"] = t.Status;
                
                foreach(TransactionDetail d in t.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["SupplementID"] = d.SupplementID;
                    drow["Quantity"] = d.Quantity;
                    drow["Subtotal"] = d.Quantity * d.MsSupplement.SupplementPrice;
                    total += d.Quantity * d.MsSupplement.SupplementPrice;
                    detailTable.Rows.Add(drow);
                }

                hrow["GrandTotal"] = total;
                headerTable.Rows.Add(hrow);
                total = 0;
            }
            return dataSet;
        }
    }
}