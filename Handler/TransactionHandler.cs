using Project1._0.Model;
using Project1._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Handler
{
    public class TransactionHandler
    {
        //baru
        public static List<TransactionHeader> getAllUserTransactionId(int transactionId)
        {
            return TransactionRepository.getAllUserTransactionsByID(transactionId);
        }
        public static List<TransactionHeader> getAllTransactions()
        {
            return TransactionRepository.getAllTransactions();
        }
        public static TransactionDetail getTransactionDetailById(int id)
        {
            return TransactionRepository.getTransactionDetailByID(id);
        }
        public static Boolean UpdateTransaction(int id)
        {
            bool u =TransactionRepository.UpdateTransaction(id);
            return u;
        }
    }
}