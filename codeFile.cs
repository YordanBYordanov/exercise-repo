using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//small update to make a conflict , first modification !


namespace zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double sum = 0;

            double[] masVal = new double[numbers];
            double maxVal = double.MinValue;
            for (int i = 0; i < numbers; i++)
            {
                double valIn = double.Parse(Console.ReadLine());
                if(valIn > maxVal)
                {
                    maxVal = valIn;
                }
                masVal[i] = valIn;
            }

            bool firstCheck = false;
            for (int i = 0; i < numbers; i++)
            {
                if(masVal[i] == maxVal && firstCheck == false)
                {
                    firstCheck = true;
                }
                else
                {
                    sum += masVal[i];
                }
               
            }
            if(sum == maxVal)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxVal}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxVal - sum)}");
            }
        }
    }
}
