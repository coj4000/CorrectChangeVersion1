using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            int amountToPay = 266;
            int paidAmount = 500;

            int changeToPayBack = paidAmount - amountToPay;


            // To keep things simple, we assume that you pay back
            // change as: 1-kr coins, 10-kr coins and 100-kr bills.

            int noOf1krCoins = 0;
            int noOf10krCoins = 0;
            int noOf100krBills = 0;


            // YOUR JOB: Add code to calculate the correct change
            while (changeToPayBack >= 100)
            {
                noOf100krBills = noOf100krBills + 1;
                changeToPayBack = changeToPayBack - 100;
            }
            while (changeToPayBack >= 10)
            {
                noOf10krCoins = noOf10krCoins + 1;
                changeToPayBack = changeToPayBack - 10;
            }
            noOf1krCoins = changeToPayBack;


            Console.WriteLine("Your change is {0} 1-kr coins, {1} 10-kr coins and {2} 100-kr bills", noOf1krCoins, noOf10krCoins, noOf100krBills);
            Console.WriteLine("A total of {0} kr", changeToPayBack);


            // The LAST line of code should be ABOVE this line
        }
    }
}
