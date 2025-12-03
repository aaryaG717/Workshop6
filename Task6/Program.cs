using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelBookingSummary
{
    // Booking class
    class Booking
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int DurationInDay { get; set; }
        public bool IsInternational { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Sample list of bookings
            List<Booking> bookings = new List<Booking>
            {
                new Booking { CustomerName = "Aarya", Destination = "Paris", Price = 15000, DurationInDay = 7, IsInternational = true },
                new Booking { CustomerName = "Ravi", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
                new Booking { CustomerName = "Sita", Destination = "Dubai", Price = 12000, DurationInDay = 5, IsInternational = true },
                new Booking { CustomerName = "Mohan", Destination = "Kathmandu", Price = 5000, DurationInDay = 2, IsInternational = false },
                new Booking { CustomerName = "Kiran", Destination = "Thailand", Price = 11000, DurationInDay = 6, IsInternational = true }
            };

            // Part 1: Filter tours above Rs. 10,000 and duration more than 4 days
            var filteredTours = bookings
                                .Where(b => b.Price > 10000 && b.DurationInDay > 4);

            // Part 2: Transform (project) into a new list with CustomName, Destination, Category, then sort
            var summaryList = filteredTours
                                .Select(b => new
                                {
                                    CustomName = b.CustomerName,
                                    b.Destination,
                                    Category = b.IsInternational ? "International" : "Domestic",
                                    b.Price
                                })
                                // Sort by Category (Domestic first) and then by Price ascending
                                .OrderBy(b => b.Category)
                                .ThenBy(b => b.Price)
                                .ToList();

            // Display the result in a clean format
            Console.WriteLine("=== Travel Booking Summary Report ===\n");
            foreach (var tour in summaryList)
            {
                Console.WriteLine($"Customer: {tour.CustomName}");
                Console.WriteLine($"Destination: {tour.Destination}");
                Console.WriteLine($"Category: {tour.Category}");
                Console.WriteLine($"Price: Rs. {tour.Price}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
