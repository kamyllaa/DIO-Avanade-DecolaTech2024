string nome = Console.ReadLine();
double quilometrosPorDia = double.Parse(Console.ReadLine());
int horasDeEletronicos = int.Parse(Console.ReadLine());
int refeicoesComCarne = int.Parse(Console.ReadLine());

double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
    
Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");
    
static double CalcularPegadaDeCarbono(double quilometrosPorDia, double horasDeEletronicos, double refeicoesComCarne)
{
    return quilometrosPorDia * 365 * 0.2 + horasDeEletronicos * 0.1 + refeicoesComCarne * 0.5;
}