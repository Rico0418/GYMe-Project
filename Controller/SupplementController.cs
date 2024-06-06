using Project1._0.Handler;
using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Controller
{
    public class SupplementController
    {
        //baru
        public static List<MsSupplement> getAllSupplements()
        {
            return SupplementHandler.getAllSupplements();
        }

        public static string getSupplementName(int suppID)
        {
            return SupplementHandler.getSupplementName(suppID);
        }
        public static bool validateName(string name)
        {
            if(string.IsNullOrEmpty(name)|| !name.Contains("Supplement")){
                return false;
            }
            return true;
        }
        public static bool validateExpiry(DateTime expiry)
        {
            if( expiry < DateTime.Now)
            {
                return false;
            }
            return true;
        }
        public static bool validatePPrice(int price)
        {
            if(price < 3000)
            {
                return false;
            }
            return true;
        }
        public static bool isEmpty(string s)
        {
            if(s == "" || s== null)
            {
                return false ;
            }
            return true;
        }
        public static string insertSupplement(string Name, DateTime ExpiryDate, int price, int typeId)
        {
           bool u = SupplementHandler.insertSupplement(Name, ExpiryDate, price, typeId);
            if (u == true)
            {
                return "insert success";
            }
            else
            {
                return "insert failed";
            }
        }
        public static string DeleteSupplement(int id)
        {
            bool u = SupplementHandler.DeleteSupplement(id);
            if (u == true)
            {
                return "delete success";
            }
            else
            {
                return "delete failed";
            }
        }
        public static string UpdateSupplement(int id, string name, DateTime expiry, int price, int typeID)
        {
            bool u = SupplementHandler.updateSupplement(id, name, expiry, price, typeID);
            if(u == true)
            {
                return "update success";
            }
            else
            {
                return "update failed";
            }
        }
        public static MsSupplement getSupplementById(int id)
        {
            MsSupplement su = SupplementHandler.getSupplementById(id);
            if(su == null)
            {
                return null;
            }
            else
            {
                return su;
            }
        }
    }
}