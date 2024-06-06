using Project1._0.Model;
using Project1._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project1._0.Handler;

namespace Project1._0.Controller
{
    public class TransactionController
    {
        //baru
        public static List<TransactionHeader> getAllUserTransactionId(int Id)
        {
            return TransactionHandler.getAllUserTransactionId(Id);
        }
        public static List<TransactionHeader> getAllTransactions()
        {
            return TransactionHandler.getAllTransactions();
        }
        public static TransactionDetail getTransactionDetailById(int id)
        {
            return TransactionHandler.getTransactionDetailById(id);
        }
        public static string updateTransaction(int id)
        {
            bool u = TransactionHandler.UpdateTransaction(id);
            if (u == true)
            {
                return "handled succesfullly";
            }
            else
            {
                return "already handled";
            }
        }
    }
}