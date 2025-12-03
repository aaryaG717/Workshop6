using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQOperatorsExample
{
    // Aggregation example: CashierSales
    class CashierSales
    {
        public string CashierName { get; set; }
        public double Sales { get; set; }
    }

    // Quantifier example: Applicant
    class Applicant
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // Element example: Music
    class Music
    {
        public string SongTitle { get; set; }
        public int DurationInSeconds { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Aggregation Operators
            List<CashierSales> cashierSales = new List<CashierSales>
            {
                new CashierSales { CashierName = "Ravi", Sales = 5000 },
                new CashierSales { CashierName = "Sita", Sales = 7000 },
                new CashierSales { CashierName = "Mohan", Sales = 6000 },
                new CashierSales { CashierName = "Kiran", Sales = 8000 }
            };

            int totalCashiers = cashierSales.Count();
            double totalSales = cashierSales.Sum(c => c.Sales);
            double highestSales = cashierSales.Max(c => c.Sales);
            double lowestSales = cashierSales.Min(c => c.Sales);
            double avgSales = cashierSales.Average(c => c.Sales);

            Console.WriteLine("=== Supermarket Sales ===");
            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: {totalSales}");
            Console.WriteLine($"Highest Sales: {highestSales}");
            Console.WriteLine($"Lowest Sales: {lowestSales}");
            Console.WriteLine($"Average Sales: {avgSales:F2}");

            // 2. Quantifier Operators
            List<Applicant> applicants = new List<Applicant>
            {
                new Applicant { Name = "Aarya", Age = 20 },
                new Applicant { Name = "Ravi", Age = 17 },
                new Applicant { Name = "Sita", Age = 19 },
                new Applicant { Name = "Mohan", Age = 15 }
            };

            bool anyUnder18 = applicants.Any(a => a.Age < 18);
            bool allAbove16 = applicants.All(a => a.Age > 16);

            Console.WriteLine("\n=== Election Commission Check ===");
            Console.WriteLine($"Are there any applicants under 18? {anyUnder18}");
            Console.WriteLine($"Are all applicants above 16? {allAbove16}");

            // 3. Element Operators
            List<Music> songs = new List<Music>
            {
                new Music { SongTitle = "Song1", DurationInSeconds = 180 },
                new Music { SongTitle = "Song2", DurationInSeconds = 250 },
                new Music { SongTitle = "Song3", DurationInSeconds = 300 },
                new Music { SongTitle = "Song4", DurationInSeconds = 420 },
                new Music { SongTitle = "Song5", DurationInSeconds = 700 }
            };

            var firstSong = songs.First();
            var lastSong = songs.Last();
            var firstAbove4Min = songs.First(s => s.DurationInSeconds > 240); // > 4 minutes
            var firstAbove10Min = songs.FirstOrDefault(s => s.DurationInSeconds > 600); // > 10 minutes

            Console.WriteLine("\n=== Music App ===");
            Console.WriteLine($"First Song: {firstSong.SongTitle}");
            Console.WriteLine($"Last Song: {lastSong.SongTitle}");
            Console.WriteLine($"First Song longer than 4 minutes: {firstAbove4Min.SongTitle}");
            Console.WriteLine($"First Song longer than 10 minutes: {(firstAbove10Min != null ? firstAbove10Min.SongTitle : "None")}");
        }
    }
}
