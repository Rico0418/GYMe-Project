using Project1._0.Model;
using Project1._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Handler
{
    public class CartHandler
    {
        //baru
        public static List<MsCart> getAllUserCart(int id)
        {
            return CartRepository.getAllUserCart(id);
        }
        public static MsCart addtoCart(int userID, int SupplementID, int Quantity)
        {
            return CartRepository.addtoCart(userID, SupplementID, Quantity);
        }

        public static void deleteAllUserCart(int userId)
        {
            CartRepository.deleteAllUserCart(userId);
        }
    }
}