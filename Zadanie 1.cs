using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("podaj pierwszą liczbę działania: ");
    float a = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("podaj operatora działania z podanych (+, -, *, /): ");
    string opt = Console.ReadLine();
    Console.WriteLine("podaj drugą liczbę działania: ");
    float b = Convert.ToSingle(Console.ReadLine());
    
    if (opt == "+")
    {
        float c = a + b;
        Console.WriteLine($"Wynik: {a} {opt} {b} = {c}");
    } else if (opt == "-")
    {
        float c = a - b;
        Console.WriteLine($"Wynik: {a} {opt} {b} = {c}");
    } else if (opt == "*")
    {
        float c = a * b;
        Console.WriteLine($"Wynik: {a} {opt} {b} = {c}");
    } else if (opt == "/")
    {
        float c = a / b;
        Console.WriteLine($"Wynik: {a} {opt} {b} = {c}");
    }
  }
}