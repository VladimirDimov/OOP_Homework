using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DefiningClassesPartOne
{
    class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            Console.WriteLine("Testing call history ...");
            GSM PeshosGSM = new GSM("Asha 201", "Nokia", 130, "Pesho Peshev", new Batery("model", 12, 6, Batery.Type.LiIon)
            , new Display(320, 240, 65000));
            PeshosGSM.AddCall(DateTime.ParseExact("25.01.2015 15:30:16", "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture), "+359123456", 568);
            PeshosGSM.AddCall(DateTime.Today, "+359123456", 320);
            PeshosGSM.AddCall(DateTime.Today, "+359123456", 15);
            PeshosGSM.AddCall(DateTime.Today, "+359123456", 130);
            PeshosGSM.AddCall(DateTime.Today, "+359123456", 1200);
            PeshosGSM.DeleteCall(0, 0);

            Console.WriteLine();
            Console.WriteLine("Pesho's bill: {0} lv.", PeshosGSM.GetTotalCallPrice());
            Console.WriteLine("List of all calls:");
            PeshosGSM.PrintCalls();
            Console.WriteLine();

            Console.WriteLine("Removing the longest call ...");
            Call maxDuration = PeshosGSM.CallHistory.Max();
            PeshosGSM.CallHistory.Remove(maxDuration);
            PeshosGSM.PrintCalls();
            Console.WriteLine("Pesho's bill: {0} lv.", PeshosGSM.GetTotalCallPrice());

            Console.WriteLine();
            Console.WriteLine("Clearing the call history ...");
            PeshosGSM.ClearCallHistory();
            foreach (var call in PeshosGSM.CallHistory)
            {
                Console.WriteLine(call);
            }
            if (PeshosGSM.CallHistory.Count == 0)
            {
                Console.WriteLine("The call history of {0} is empty", PeshosGSM.Owner);
            }

        }
    }
}
