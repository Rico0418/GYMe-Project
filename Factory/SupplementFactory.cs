using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Project1._0.Factory
{
    public class SupplementFactory
    {
        //baru
        public static MsSupplement createNewSupplement(string name, DateTime ExpiryDate, int price, int typeID)
        {
            MsSupplement supplement = new MsSupplement();
            supplement.SupplementName = name;
            supplement.SupplementExpiryDate = ExpiryDate;
            supplement.SupplementPrice = price;
            supplement.SupplementTypeID = typeID;
            return supplement;
        }
        public static MsSupplementType createNewSupplementType(int name)
        {
            MsSupplementType supplementType = new MsSupplementType();
            supplementType.SupplementTypeName = name;
            return supplementType;

        }
    }
}