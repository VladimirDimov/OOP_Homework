using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class GSMTest
    {
        static void Main()
        {

            var GsmList = new List<GSM>();

            GsmList.Add(new GSM("Galaxy", "Samsung"));

            GsmList.Add(new GSM("Asha", "Nokia", 150, "Gosho", new Batery("model", 12, 6, Batery.Type.LiIon),
                    new Display(320, 240, 65000)));

            foreach (var gsm in GsmList)
            {
                Console.WriteLine();
                Console.WriteLine(gsm.ToString());
            }

            GSM iphone4S = GSM.IPhone4S;
            Console.WriteLine(iphone4S.ToString());

            GSMCallHistoryTest.TestCallHistory();
        }

    }
}
