using System;
using System.Collections.Generic;
using System.Text;

namespace PacktShared
{
    public class BankAccount
    {
        public string AccountName; // instance member
        public decimal Balance; // instance member
        public static decimal InterestRate; // shared member
    }
}
