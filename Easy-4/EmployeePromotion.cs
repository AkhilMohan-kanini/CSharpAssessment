using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_4
{
    class EmployeePromotion 
    {
        
        static List<string> employeePromotionList = new List<string>();
        
        public static void AddEmployeePromotion()
        {
            bool flag = true;

            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop) ");

            while (flag)
            {
                
                string name = Console.ReadLine();

                if (name == string.Empty)
                    flag = false;
                else
                    employeePromotionList.Add(name);
            }  
        }

        public static void ShowPromotionList()
        {
            int i=1;
            Console.WriteLine("Promotion List : ");
            employeePromotionList.Sort();
            foreach(string name in employeePromotionList)
            {
                Console.WriteLine(i++ + "." + name);
            }
        }



    }
}
