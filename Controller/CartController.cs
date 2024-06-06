using Project1._0.Handler;
using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Controller
{
    public class CartController
    {
        //baru
        public static List<MsCart> getAllUserCart(int id)
        {
            return CartHandler.getAllUserCart(id);
        }
        public static MsCart addtoCart(int userID, int SupplementID, int Quantity)
        {
            return CartHandler.addtoCart(userID, SupplementID, Quantity);
        }

        public static void deleteAllUserCart(int userId)
        {
            CartHandler.deleteAllUserCart(userId);
        }
    }
}