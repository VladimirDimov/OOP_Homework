using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class Program
    {
        static void Main()
        {
            GSM myPhone = new GSM();
            myPhone.Model = "Nokia";
            myPhone.DisplayProperties.Size = "320x240";
            Console.WriteLine(myPhone.Model);
            Console.WriteLine(myPhone.DisplayProperties.Size);

            GSM secondPhone = new GSM("Nokia", "GermanyOOD", 100, "Vladko");
            Console.WriteLine(secondPhone.Batery.Model);


        }
    }
}
