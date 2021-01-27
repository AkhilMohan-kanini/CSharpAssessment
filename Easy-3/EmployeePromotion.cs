using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_3
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

            Console.WriteLine("The current size of the collection is {0}", employeePromotionList.Capacity);
            employeePromotionList.TrimExcess();
            Console.Write("The size after removing the extra space is {0}", employeePromotionList.Capacity);
        }

        public static void ShowPromotionList()
        {
            int i=1;
            Console.WriteLine("Promotion List : ");
            foreach(string name in employeePromotionList)
            {
                Console.WriteLine(i++ + "." + name);
            }
        }



    }
}
