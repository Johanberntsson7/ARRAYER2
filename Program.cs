using System.Diagnostics.CodeAnalysis;

namespace ARRAYER2;

class Program
{
    static void Main(string[] args)
    {
        // Skapa en konsolapplikation som hanterar ett antal tal i en array.
        // Be användaren ange hur många tal som ska lagras.
        Console.WriteLine("Skriv in hur många tal du vill mata in:");   
        // Skapa en int[] med den storleken.
        

        
        int antal = int.Parse(Console.ReadLine()!);
        int[] antaltal = new int[antal];

        for (int i = 0; i < antaltal.Length; i++)   // <-- i++ står HÄR och bara här
        
    {
    Console.WriteLine($"Skriv in tal {i + 1}:");
    antaltal[i] = int.Parse(Console.ReadLine()!);   // <-- bara i, ingen ++
    }
        int sum = 0;
        Console.WriteLine("Du matade in:");
        foreach (int tal in antaltal)
        {
        Console.WriteLine(tal);
        sum += tal;
        }
        Console.WriteLine($"Summan är : {sum}");
        double medelvarde = (double)sum / antal;
        Console.WriteLine($"Medelvärdet är: {medelvarde}");

        // Be användaren mata in varje tal och spara det i arrayen.
        // Skriv ut alla tal som användaren matade in.
        // (Utmaning) Beräkna och skriv ut summan och medelvärdet av talen.

        // 💡 Tips:
        // Använd for-loop för inmatning och utskrift.
        // Använd array.Length för att ta reda på hur många element som finns.
    }
}
