using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_3
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.WriteLine("\nOptions : ");
                Console.WriteLine("1. Add an Employee for promotion ");
                Console.WriteLine("2. Show Employees Promotion List ");
                Console.WriteLine("3. Exit \n");

                Console.Write("Enter your Choice (1, 2 or 3): ");
                int choice=0;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid Value !! Enter 1, 2 or 3");
                }

                if(choice==1)
                {
                    EmployeePromotion.AddEmployeePromotion();
                }
                else if(choice ==2)
                {
                    EmployeePromotion.ShowPromotionList();
                }
                else if(choice ==3)
                {
                    return;
                }
                else if(choice ==0)
                { }
                else
                {
                    Console.WriteLine("Invalid Option !! Enter 1, 2 or 3 ");
                }

            }
        }
    }




}
