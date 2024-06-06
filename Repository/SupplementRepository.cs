using Project1._0.Factory;
using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Repository
{
    public class SupplementRepository
    {
        static Database1Entities db = new Database1Entities();
        public static List<MsSupplement> getAllSupplements()
        {
            List<MsSupplement> supps = (from p in db.MsSupplements select p).ToList();
            return supps;
        }
        public static string getSupplementName(int suppID)
        {
            return (from p in db.MsSupplements where p.SupplementID == suppID select p.SupplementName).FirstOrDefault();
        }
        public static void insertSupplement (string Name, DateTime ExpiryDate, int price, int typeId)
        {
            MsSupplement supplement = SupplementFactory.createNewSupplement(Name, ExpiryDate, price, typeId);
            db.MsSupplements.Add(supplement);
            db.SaveChanges();
        }
        public static MsSupplement getSupplementById(int id)
        {
            MsSupplement supplement  = (from x in db.MsSupplements where x.SupplementID.Equals(id) select x).FirstOrDefault();
            return supplement;
        }
        public static void updateSupplements(int id, string name, DateTime expiryDate, int price, int typeId)
        {
            MsSupplement supplement = db.MsSupplements.Find(id);
            supplement.SupplementName = name;
            supplement.SupplementExpiryDate = expiryDate;
            supplement.SupplementPrice = price;
            supplement.SupplementTypeID = typeId;
            db.SaveChanges();
        }
        public static void DeleteSupplement(int id)
        {
            MsSupplement supplement = db.MsSupplements.Find(id);
            db.MsSupplements.Remove(supplement);
            db.SaveChanges();
        }
    }
}