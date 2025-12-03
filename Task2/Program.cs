using System;

namespace DelegateExample
{
    // Part 1: Arithmetic delegate
    public delegate int Calculate(int a, int b);

    // Part 2: Discount delegate
    public delegate double DiscountStrategy(double price);

    class Program
    {
        // Part 1 Methods
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Part 2 Methods
        static double FestivalDiscount(double price)
        {
            return price * 0.8; // 20% off
        }

        static double SeasonalDiscount(double price)
        {
            return price * 0.9; // 10% off
        }

        static double NoDiscount(double price)
        {
            return price; // No discount
        }

        // 2.1 Method using delegate
        static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            return strategy(originalPrice);
        }

        static void Main(string[] args)
        {
            // Part 1: Using Calculate delegate
            Calculate calcAdd = Add;
            Calculate calcSubtract = Subtract;

            int sum = calcAdd(10, 5);
            int difference = calcSubtract(10, 5);

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);

            Console.WriteLine("\n--- Discount Strategy ---");

            double originalPrice = 1000;

            // 2.2 Calling CalculateFinalPrice with different discount strategies
            double festivalPrice = CalculateFinalPrice(originalPrice, FestivalDiscount);
            double seasonalPrice = CalculateFinalPrice(originalPrice, SeasonalDiscount);
            double noDiscountPrice = CalculateFinalPrice(originalPrice, NoDiscount);

            Console.WriteLine($"Original Price: {originalPrice}");
            Console.WriteLine($"Festival Discount Price: {festivalPrice}");
            Console.WriteLine($"Seasonal Discount Price: {seasonalPrice}");
            Console.WriteLine($"No Discount Price: {noDiscountPrice}");

            // 2.3 Using lambda expression for 30% discount
            double lambdaDiscountPrice = CalculateFinalPrice(originalPrice, price => price * 0.7);
            Console.WriteLine($"Lambda 30% Discount Price: {lambdaDiscountPrice}");
        }
    }
}
