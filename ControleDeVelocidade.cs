using System;

class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }

    public int ObterVelocidadeAtual()
    {
        return VelocidadeAtual;
    }
}

class Program
{
    static void Main()
    {
        string[] limites = Console.ReadLine().Split(' ');
        int velocidadeMinima = int.Parse(limites[0]);
        int velocidadeMaxima = int.Parse(limites[1]);

        Robo r1 = new Robo(velocidadeMinima, velocidadeMaxima);

        string comandos = Console.ReadLine();

        foreach (char comando in comandos)
        {
            if (comando == 'A')
            {
                r1.Acelerar();
            }
            else if (comando == 'D')
            {
                r1.Desacelerar();
            }
        }

        Console.WriteLine(r1.ObterVelocidadeAtual());
    }
}
