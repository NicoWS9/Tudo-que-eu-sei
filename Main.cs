using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
        while(true){
            Console.WriteLine("Ola, " + nome);
            Console.WriteLine("Digite um Numero");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um Numero");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A Soma dos numeros {N1} e {N2} e igual a: {N1 + N2}");
            Console.WriteLine("Deseja Continuar: 1-Sim / 2-Nao");
            int continuar = Convert.ToInt32(Console.ReadLine());
            if (continuar != 1){
                break;}
        }
    }
}