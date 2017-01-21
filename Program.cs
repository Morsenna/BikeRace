using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJuniorsCyclists = int.Parse(Console.ReadLine());
            int numSeniorsCyclists = int.Parse(Console.ReadLine());
            string typeTrack = Console.ReadLine() ;
            double feeForJuniors = 0;
            double feeForSeniors = 0;
            int sumOfAllCyclists = numJuniorsCyclists + numSeniorsCyclists;

            if (typeTrack == "trail")
            {
                feeForJuniors = numJuniorsCyclists * 5.50;
                feeForSeniors = numSeniorsCyclists * 7;
                double allFee = feeForSeniors + feeForJuniors;
                double discount = allFee * 0.05;
                double result = allFee - discount;
                Console.WriteLine("{0:f2}", result);

            }
            else if (typeTrack == "cross-country")
            {
                if (sumOfAllCyclists >= 50)
                {
                    feeForJuniors = numJuniorsCyclists * 8;
                    feeForSeniors = numSeniorsCyclists * 9.50;
                    double allFee = feeForSeniors + feeForJuniors;
                    double discount = allFee * 0.25;
                    double result = allFee - discount;
                    double AnotherDiscount = result * 0.05;
                    double finalResultAsterAllDiscounts = result - AnotherDiscount;
                    Console.WriteLine("{0:f2}", finalResultAsterAllDiscounts);
                }
                else if (sumOfAllCyclists < 50)
                {
                    feeForJuniors = numJuniorsCyclists * 8;
                    feeForSeniors = numSeniorsCyclists * 9.50;
                    double allFee = feeForSeniors + feeForJuniors;
                    double discount = allFee * 0.05;
                    double result = allFee - discount;
                    Console.WriteLine("{0:f2}", result);

                }

            }
            else if (typeTrack == "downhill")
            {
                feeForJuniors = numJuniorsCyclists * 12.25;
                feeForSeniors = numSeniorsCyclists * 13.75;
                double allFee = feeForSeniors + feeForJuniors;
                double discount = allFee * 0.05;
                double result = allFee - discount;
                Console.WriteLine("{0:f2}", result);


            }
            else if (typeTrack == "road")
            {
                feeForJuniors = numJuniorsCyclists * 20;
                feeForSeniors = numSeniorsCyclists * 21.50;
                double allFee = feeForSeniors + feeForJuniors;
                double discount = allFee * 0.05;
                double result = allFee - discount;
                Console.WriteLine("{0:f2}", result);

            }
        }
    }
}
