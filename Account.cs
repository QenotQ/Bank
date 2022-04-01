using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_A
{
    public class Account
    {
        public string Number { get; set; }
        public Bank Bank { get; set; }
        public Client Client { get; set; }
        public decimal Sum { get; set; }
        public Currency Currency { get; set; }

        public Account(string number, Bank bank, Client client, Currency currency)
        {
            Number = number;
            Bank = bank;
            Client = client;
            Currency = currency;
        }
     }
}
