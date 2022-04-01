using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_A
{
   public class Check
    {
        public string TransactionNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Sum { get; set; }
        public string Message { get; set; }
       

        public Check(string transactionNumber, DateTime transactionDate, 
            string bankName, string accountNumber, TransactionType transactionType, decimal sum)
        {
            TransactionNumber = transactionNumber;
            TransactionDate = transactionDate;
            BankName = bankName;
            AccountNumber = accountNumber;
            TransactionType = transactionType;
            Sum = sum;
            
        }
       
        public override string ToString()
        {
            string transactionType = string.Empty;
            Message = "OK";
            switch(TransactionType)
            {
                case TransactionType.Withdraw: transactionType = "Снятие наличных";break;
                case TransactionType.Refill: transactionType = "Внесение наличных"; break;
                case TransactionType.Transfer: transactionType = "Перевод"; break;
            }
            return $"{TransactionNumber}\n{TransactionDate.ToString("dd/MM HH:mm")}\n{BankName} {transactionType}\nСумма:{Sum}";
        }
    }
}
