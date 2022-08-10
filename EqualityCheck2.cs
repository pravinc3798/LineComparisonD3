﻿
namespace LineComparisonD3
{
    public class EqualityCheck2
    {
        public static void UsingCompareTo()
        {
            Console.WriteLine("Enter x1 y1 x2 y2 for 1st line : ");
            var line = Console.ReadLine();
            var data = line.Split(' ');
            var x1 = int.Parse(data[0]);
            var y1 = int.Parse(data[1]);
            var x2 = int.Parse(data[2]);
            var y2 = int.Parse(data[3]);

            var lengthOne = LineLength.LengthCalculation(x1, y1, x2, y2);

            Console.WriteLine("Enter x1 y1 x2 y2 for 2nd line : ");
            var line2 = Console.ReadLine();
            var data2 = line2.Split(' ');
            var x12 = int.Parse(data2[0]);
            var y12 = int.Parse(data2[1]);
            var x22 = int.Parse(data2[2]);
            var y22 = int.Parse(data2[3]);

            var lengthTwo = LineLength.LengthCalculation(x12, y12, x22, y22);

            Console.WriteLine("\n Length of Line 1 : {0} , Length of Line 2 : {1}", lengthOne, lengthTwo);
            if (lengthOne.CompareTo(lengthTwo) == 0)
                Console.WriteLine("Lines are Equal");
            else
                Console.WriteLine("Lines are Not Equal");
        }
    }
}
