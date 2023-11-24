namespace GIK299_Mahmed_Huseen
{
internal class Program
{
    static void Main() 
    {
        // Deklarerar variabler
        string name1;
        int age1;
        string name2;
        int age2;
        string name3;
        int age3;
        string name4;
        int age4; 

        // Input och Output för varje famljemedlem
        Console.WriteLine("Ange namn");
        name1 = Console.ReadLine();
        Console.WriteLine("Ange ålder");
        age1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ange namn");
        name2 = Console.ReadLine();
        Console.WriteLine("Ange ålder");
        age2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ange namn"); 
        name3 = Console.ReadLine();
        Console.WriteLine("Ange ålder");
        age3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ange namn");
        name4 = Console.ReadLine();
        Console.WriteLine("Ange ålder");
        age4 = Convert.ToInt32(Console.ReadLine());

        // Be användaren om namn och ålder för varje familjmedlem
         Console.WriteLine(name1 + " är " + age1 + " år gammal");
         Console.WriteLine(name2 + " är " + age2 + " år gammal");
         Console.WriteLine(name3 + " är " + age3 + " år gammal");
         Console.WriteLine(name4 + " är " + age4 + " år gammal");

        // Skriv ut sammanlagd ålder och medelålder 
        double totalAge = age1 + age2 + age3 + age4;
        double median = totalAge / 4;
        string dec = median.ToString("0.00");
        Console.WriteLine("Totalålder: " + totalAge);
        Console.WriteLine("Medelålder : " + dec);
    }
} 
}