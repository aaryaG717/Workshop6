using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    // Book class for filtering example
    class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }

    // Student class for sorting example
    class Student
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Selecting / Projection: square numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(n => n * n).ToList();

            Console.WriteLine("Squared Numbers:");
            foreach (var sq in squaredNumbers)
            {
                Console.WriteLine(sq);
            }

            // 2. Filtering (Where): premium books priced above 1000
            List<Book> books = new List<Book>
            {
                new Book { Title = "C# in Depth", Price = 1200 },
                new Book { Title = "ASP.NET Core", Price = 900 },
                new Book { Title = "LINQ Essentials", Price = 1500 },
                new Book { Title = "Programming Basics", Price = 800 }
            };

            var premiumBooks = books.Where(b => b.Price > 1000).ToList();

            Console.WriteLine("\nPremium Books (Price > 1000):");
            foreach (var book in premiumBooks)
            {
                Console.WriteLine($"{book.Title} - Rs. {book.Price}");
            }

            // 3. Sorting (OrderBy): sort students alphabetically
            List<Student> students = new List<Student>
            {
                new Student { Name = "Ravi" },
                new Student { Name = "Aarya" },
                new Student { Name = "Sita" },
                new Student { Name = "Mohan" },
                new Student { Name = "Kiran" }
            };

            var sortedStudents = students.OrderBy(s => s.Name).ToList();

            Console.WriteLine("\nStudents Sorted Alphabetically:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
