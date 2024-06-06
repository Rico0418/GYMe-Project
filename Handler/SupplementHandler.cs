using Project1._0.Model;
using Project1._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Handler
{
    public class SupplementHandler
    {
        //baru
        public static List<MsSupplement> getAllSupplements()
        {
            return SupplementRepository.getAllSupplements();
        }
        public static string getSupplementName(int suppID)
        {
            return SupplementRepository.getSupplementName(suppID);
        }
        public static Boolean insertSupplement (string Name, DateTime ExpiryDate, int price, int typeId)
        {
            SupplementRepository.insertSupplement(Name, ExpiryDate, price, typeId);
            return true;
        }
        public static Boolean DeleteSupplement(int id)
        {
            SupplementRepository.DeleteSupplement(id);
            return true;
        }
        public static Boolean updateSupplement(int id, string name, DateTime expiryDate, int price, int typeId)
        {
            SupplementRepository.updateSupplements(id, name, expiryDate, price, typeId);
            return true;
        }
        public static MsSupplement getSupplementById(int id)
        {
            MsSupplement supplement = SupplementRepository.getSupplementById(id);
            if(supplement == null)
            {
                return null;
            }
            else
            {
                return supplement;
            }
        }
    }
}