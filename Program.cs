// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using OrtalamaHesabı;

public class Program //Beklenilen sonuçları vermektedir
{
    static void Main(string[] args)
    {
        Fibonacci fibonacci = new Fibonacci();
        Average average = new Average();

        Console.Write("Derinlik giriniz:");
        int depth = int.Parse(Console.ReadLine());

        int[] series = fibonacci.CFibonacci(depth); // Fibonacci metodunda return edilen diziyi series int dizisine atadım	
        double series_average = average.CAverage(series);
        Console.Write("Fibonacci serisinin ortalaması: " + series_average);

        Console.ReadKey();
    }
}