using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Atm
    {
        public static decimal balance = 300;
        public static List<string> records = new List<string>();
        public static int count = 0;
        public static void UserInterface() 
        {
            Console.WriteLine("Wellcome to Atm Bank ");
            int num=0;
            while (num != 3) 
            { 
            Console.WriteLine($"Your Balance now is ${ViewBlance()}");
            Console.WriteLine("input 1 To Deposit");
            Console.WriteLine("input 2 To WithDraw");
            Console.WriteLine("input 3 To exit");
             num=Convert.ToInt32(Console.ReadLine());
            if (num == 1) 
            {
                Console.WriteLine("How much money you want Deposit");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());
             Deposit(num1);
            }
            if (num == 2) 
            {
                Console.WriteLine("How much money you want WithDraw");
                decimal num2 = Convert.ToDecimal(Console.ReadLine());
                WithDraw(num2);
            }
            }
            foreach (string record in records)
            {
                Console.WriteLine(record);
            }
            
        }
        public static decimal ViewBlance()
        {
           
            return balance;
        }
        public static decimal WithDraw(decimal m)
        {
            if (balance < m)
            {
                throw new Exception($"you can't withDraw {m} becouse your balance is {balance}");
            }
            else if(m < 0) 
            {
                throw new Exception($"you can't withDraw {m} becouse it's negative");
            }
            count++;
            
            balance -= m;
            records.Add($"operetion {count} withDraw:{m} Balance:{balance} Data: {DateTime.Now}");
            return balance;
           


        }
        public static decimal Deposit(decimal m)
        {
            if (m < 0)
            {
                throw new Exception($"you can't Deposit {m} becouse it's negative");
            }
            count++;
            
            balance += m;
            records.Add($"operetion {count} Deposit:${m} Balance:{balance} Data: {DateTime.Now}");
            return balance;
        }
    }
}
