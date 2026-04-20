using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Ile ocenek? ");
    int liczba_ocen = Convert.ToInt32(Console.ReadLine());
    int[] lista_ocen = new int[liczba_ocen];
    
    int i = 0;
    double suma_ocen = 0;
    
    while (i < liczba_ocen)
    {
        Console.WriteLine($"Podaj {i + 1} ocenę: ");
        int ii = Convert.ToInt32(Console.ReadLine());
        
        if (ii >= 1 && ii <= 6)
        {
            lista_ocen[i] = ii;
            suma_ocen = suma_ocen + lista_ocen[i];
            i++;
        } else
        {
            Console.WriteLine($"Najprawdopobniej wyszedłeś poza skalę ocen, naciśnij enter by kontynuować.");
        }
    }
    
    double srednia = Math.Round(suma_ocen / liczba_ocen, 2);
    
    Console.WriteLine($"Średnia: {srednia}");
    if (srednia >= 3)
    {
        Console.WriteLine("Uczeń zdał! Gratkikulacje");
    }
    else
    {
        Console.WriteLine("Uczeń nie zdał! No i też spoko");
    }
  }
}