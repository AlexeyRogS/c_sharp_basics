using System;
using System.IO;

namespace Homework
{
    public class Class1
    {
        public static int CountPositive(StringReader input=null) {
            if (input != null) Console.SetIn(input);
            string numbers = Console.ReadLine();
            int current_num;
            int count = 0;
            foreach (string num_s in numbers.Split(',')) {
                if (!int.TryParse(num_s, out current_num)) throw new InvalidCastException(num_s + " is not a valid integer");
                if (current_num > 0) count += 1;
            }
            return count;
        }

        public static Tuple<double, double> GetIntercectionPoint(Tuple<double, double> l1, Tuple<double, double> l2) {
            // line1: y = x * l1.Item1 + l1.Item2; line2: y = x * l2.Item1 + l2.Item2
            if (l1.Item1 == l2.Item1) throw new ArgumentException("The lines are parallel");
            double x = (l1.Item2 - l2.Item2) / (l2.Item1 - l1.Item1);
            double y = x * l1.Item1 + l1.Item2; 
            return Tuple.Create(x, y);
        }
    }
}
