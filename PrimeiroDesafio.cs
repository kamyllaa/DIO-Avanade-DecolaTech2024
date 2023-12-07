using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Program
{
    static void Main()
    {
        Pessoa p1 = new Pessoa
        {
            Nome = Console.ReadLine(),
            Idade = Convert.ToInt32(Console.ReadLine())
        };

        Console.WriteLine($"Nome: {p1.Nome}, Idade: {p1.Idade}");
    }
}
