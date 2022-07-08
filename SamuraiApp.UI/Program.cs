using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;

class Program
{
    public static SamuraiContext _context = new SamuraiContext();
    static public void Main(String[] args)
    {
        Console.WriteLine("Main Method");
        _context.Database.EnsureCreated();
        GetSamurais();
        AddSamurai();
        GetSamurais();
        Console.WriteLine("Main Method");
    }

    static private void AddSamurai()
    {
        var samurai = new Samurai { Name = "Sampson2" };
        _context.Samurais.Add(samurai);
        _context.SaveChanges();
    }
    static private void GetSamurais()
    {
        var text = " nuj";
        var samurais = _context.Samurais.ToList();
        Console.WriteLine($"{text}: Samurai count is {samurais.Count}");
        foreach (var samurai in samurais)
        {
            Console.WriteLine(samurai.Name);
        }
    }
}
