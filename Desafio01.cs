using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Por favor informe a quantidade de horas gastas na viagem");
        int horasViagem = int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor informe a velocidade média durante a viagem");
        int velocidadeMedia = int.Parse(Console.ReadLine());
        int distancia = horasViagem * velocidadeMedia;
        int litrosUsados = distancia / 12;

        Console.WriteLine("Seu consumo foi estes: " + litrosUsados);

    }

}
