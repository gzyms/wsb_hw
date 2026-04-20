using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Wybierz jednostkę wejściowej wartości (c / f): ");
    string opt = Console.ReadLine();
    
    Console.WriteLine("Podaj wartość wejściową: ");
    double a = Convert.ToDouble(Console.ReadLine());
    
    if (opt == "c")
    {
        double b = Math.Round((a - 32) * (5.0/9.0), 2);
        Console.WriteLine($"({a} - 32) * (5/9) = {b}");
    } else if (opt == "f")
    {
        double b = Math.Round((a * 1.8) + 32, 2;
        Console.WriteLine($"({a} * 1.8) + 32 = {b}");
    }
  }
}