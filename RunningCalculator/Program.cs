using System;

namespace RunningCalculator
{
    class Program
    {
        const double KM_SEMI_MARATHON = 21.0975;
        const double KM_MARATHON = 42.195;
        const double KM_10 = 10.00;
        const double KM_TRAIN = 9.00;

        static void Main(string[] args)
        {
            TimeSpan tempsParKm = new TimeSpan(0, 5, 30);

            Console.WriteLine($"--- [Allure : {tempsParKm.ToString(@"mm\:ss")}/km] ---\n");
            Console.WriteLine("Temps au 10kms : " + CalculTotal(tempsParKm, KM_10));
            Console.WriteLine("Temps au semi-marathon : " + CalculTotal(tempsParKm, KM_SEMI_MARATHON));
            Console.WriteLine("Temps au marathon : " + CalculTotal(tempsParKm, KM_MARATHON));
            Console.WriteLine($"Temps pour {KM_TRAIN}kms : {CalculTotal(tempsParKm, KM_TRAIN)}");
            Console.ReadKey();
        }

        static string CalculTotal(TimeSpan tempsParKm, double distanceEnKms)
        {
            var totalMinutesForSemiMarathon = distanceEnKms * tempsParKm.TotalMinutes;
            return (TimeSpan.FromMinutes(totalMinutesForSemiMarathon)).ToString(@"hh\hmm\:ss");
        }
    }
}