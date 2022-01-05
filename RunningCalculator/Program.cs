using System;

namespace RunningCalculator
{
    class Program
    {
        const double KM_SEMI_MARATHON = 21.0975;
        const double KM_MARATHON = 42.195;
        const double KM_TRAIN = 9.00;

        static void Main(string[] args)
        {
            TimeSpan tempsParKm = new TimeSpan(0, 5, 55);

            Console.WriteLine("Temps par km : " + tempsParKm.ToString(@"mm\:ss"));
            Console.WriteLine("Temps au semi-marathon :" + CalculTotal(tempsParKm, KM_SEMI_MARATHON));
            Console.WriteLine("Temps au marathon :" + CalculTotal(tempsParKm, KM_MARATHON));
            Console.WriteLine($"Temps pour {KM_TRAIN}kms : {CalculTotal(tempsParKm, KM_TRAIN)}");
        }

        static string CalculTotal(TimeSpan tempsParKm, double distanceEnKms)
        {
            var totalMinutesForSemiMarathon = distanceEnKms * tempsParKm.TotalMinutes;
            return (TimeSpan.FromMinutes(totalMinutesForSemiMarathon)).ToString(@"hh\hmm\:ss");
        }
    }
}
