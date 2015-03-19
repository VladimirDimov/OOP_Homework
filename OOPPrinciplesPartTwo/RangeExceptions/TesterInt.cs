namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    class TesterInt
    {
        static void Main()
        {
            // Test with int
            int[] arrayOfInt = { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine("Enter an index in the range {0} to {1}", 0, arrayOfInt.Length - 1);
                int index = int.Parse(Console.ReadLine());
                if (index < 0 || index > arrayOfInt.Length - 1)
                {
                    throw new InvalidRangeException<int>("Index out of range", 0, arrayOfInt.Length - 1);
                }
                Console.WriteLine(arrayOfInt[index]);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Valid range: [{0}, {1}]", ex.Start, ex.End);
            }

            // Test  with DateTime
            Console.WriteLine();
            DateTime startDate = new DateTime(1980, 1,1);
            DateTime endDate = new DateTime(2013,12,31);
            Console.WriteLine("Enter adate in format dd.MM.yyyy");
            try
            {
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            if (date < startDate || date > endDate)
            {
                throw new InvalidRangeException<DateTime>("Invalid date", startDate, endDate);
            }

            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Valid range: [{0}, {1}]", ex.Start.ToShortDateString(), ex.End.ToShortDateString());
            }

        }

    }
}
