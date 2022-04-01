using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_A
{
    public class Card
    {
        public string Number { get; set; }
        public Bank Bank { get; set; }
        public string CardVarificationValue { get; set; }
        public DateTime ValidThru { get; set; }
        public Client CardHolder { get; set; }
        public PaymentSystem PaymentSystem { get; set; }
        public Account Account { get; set; }
        public string error = "Недостаточно средств на счете для выполнения операции";
        
        public Card(string number, Bank bank, string cardVarificationValue, 
            DateTime validThru, Client cardHolder, PaymentSystem paymentSystem, Account account)
        {
            Number = number;
            Bank = bank;
            CardVarificationValue = cardVarificationValue;
            ValidThru = validThru;
            CardHolder = cardHolder;
            PaymentSystem = paymentSystem;
            Account = account;
            
            
        }
        public Check Withdraw(decimal value)
        {
            if (Account.Sum < value)
            {
                Console.WriteLine(error);
                return null;
            }
                


            Random random = new Random();

            Account.Sum -= value;

            var date = DateTime.Now;
            return new Check($"{random.Next(10) * 10}{random.Next(10) * 10}{random.Next(10)}",
                  date, Bank.Name, Account.Number, TransactionType.Withdraw, Account.Sum);
                  


        }
        public Check Refill(decimal value)
        {

            Random random = new Random();

            Account.Sum += value;

            var date = DateTime.Now;
            return new Check($"{random.Next(10) * 10}{random.Next(10) * 10}{random.Next(10)}",
                  date, Bank.Name, Account.Number, TransactionType.Refill, Account.Sum);


        }
        public Check Transfer(decimal value)
        {
            if (Account.Sum < value)
            {
                Console.WriteLine(error);
                return null;
            }
                
            

            Random random = new Random();

            Account.Sum -= value;

            var date = DateTime.Now;
            return new Check($"{random.Next(10) * 10}{random.Next(10) * 10}{random.Next(10)}",
                  date, Bank.Name, Account.Number, TransactionType.Transfer, Account.Sum);




        }
    }
}
