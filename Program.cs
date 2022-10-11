using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to Our application !!");
            Console.WriteLine("Please enter how many days you want to pay after :");
           int days=int.Parse(Console.ReadLine());
            Microsoft.VisualBasic.DateAndTime.DateAdd(Microsoft.VisualBasic.DateInterval.Day,days, DateTime.Now);
            Console.WriteLine("The first payment will be on :" + Microsoft.VisualBasic.DateAndTime.DateAdd(Microsoft.VisualBasic.DateInterval.Day, days, DateTime.Now));
        }
    }
}
