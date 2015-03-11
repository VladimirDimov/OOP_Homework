using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            Console.WriteLine("Testing call history ...");
            GSM PeshosGSM = new GSM("Asha 201", "Nokia", 130, "Pesho Peshev", new Batery("model", 12, 6, Batery.Type.LiIon)
            , new Display(320, 240, 65000));
            PeshosGSM.AddCall(DateTime.Today, "+359123456", 568);
            PeshosGSM.AddCall(DateTime.Today, "+359123456", 320);
            PeshosGSM.AddCall(DateTime.Today, "+359123456", 15);
            PeshosGSM.AddCall(DateTime.Today, "+359123456", 130);
            PeshosGSM.AddCall(DateTime.Today, "+359123456", 1200);
            PeshosGSM.DeleteCall(0, 0);

            Console.WriteLine("Pesho's bill: {0} lv.", PeshosGSM.GetTotalCallPrice());

            Console.WriteLine("Removing the longest call ...");
            PeshosGSM.CallHistory.Remove(PeshosGSM.CallHistory.Max(x => x.Duration));
            Console.WriteLine("Pesho's bill: {0} lv.", PeshosGSM.GetTotalCallPrice());

        }
    }
}
