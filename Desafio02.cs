using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine(" Bom dia ,aqui se encontram os nossos produtos e seus respectivos códigos de compra  (P1) CachorroQuente   (P2) X-Salada   (P3) X-Bacon  (P4) TorradaSimples          P5) Refrigerante");

        float P1 = 4.00f;
        float P2 = 4.50f;
        float P3 = 5.00f;
        float P4 = 2.00f;
        float P5 = 1.50f;


        Console.WriteLine("Digite o código do produto que deseja comprar");

        int ProdutoDesejado = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade desejada");

        int QuantidadeDesejada = int.Parse(Console.ReadLine());


        if (ProdutoDesejado == 1)
        {
            Console.WriteLine("O valor total da sua compra é de: " + QuantidadeDesejada * P1);

        }
        else if (ProdutoDesejado == 2)
        {
            Console.WriteLine("O valor total de sua compra é de " + P2 * QuantidadeDesejada);
        }
        else if (ProdutoDesejado == 3)
        {
            Console.WriteLine("O valor total de sua compra é de " + P3 * QuantidadeDesejada);
        }
        else if (ProdutoDesejado == 4)
        {
            Console.WriteLine("O valor total de sua compra é de " + P4 * QuantidadeDesejada);
        }
        else if (ProdutoDesejado == 5)
        {
            Console.WriteLine("O valor total de sua compra é de " + P5 * QuantidadeDesejada);

        }



    }
   
}  
