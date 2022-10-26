using PrototypeStudio;
using System;

class Program
{
    static void Main(string[] args)
    {
        //Crie uma instância para a pessoa (p1) e atribua valores a seus campos
        Pessoa p1 = new Pessoa();
        p1.Idade = 17;
        p1.Nome = "Tonho Teto";
        p1.IdInfo = new IdInfo(22);

        // Faz Shallow Copy de p1 e atribua a p2
        Pessoa p2 = p1.ShallowCopy();

        // Faz uma deep copy de p1 e atribua-a a p3
        Pessoa p3 = p1.DeepCopy();

        // Mostra os valores de p1, p2 e p3.
        Console.WriteLine("Valores Originais de p1, p2, p3:");
        Console.WriteLine(" Valor atual de p1: ");
        DisplayValues(p1);
        Console.WriteLine(" Valor atual de p2:");
        DisplayValues(p2);
        Console.WriteLine(" Valor atual de p3:");
        DisplayValues(p3);


        Console.WriteLine();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine();

        // Muda o valor das propriedades(ID) de p1 e exibe os valores de p1, p2 e p3
        p1.Idade = 18;
        p1.Nome = "Adsinho faz nada";
        p1.IdInfo.IdNum = 13;
        Console.WriteLine("\nValores de p1, p2 e p3 apos mudanças para p1:");
        Console.WriteLine(" Valor atual de p1: ");
        DisplayValues(p1);
        Console.WriteLine(" Valor atual de p2 (Terá mudanças nos valores):");
        DisplayValues(p2);
        Console.WriteLine(" Valor atual de p3 (Continuo a mesma coisa):");
        DisplayValues(p3);
        
    }

    public static void DisplayValues(Pessoa p)
    {
        Console.WriteLine(" Nome: {0:s}, Idade: {1:d}", p.Nome, p.Idade);
        Console.WriteLine(" Id#: {0:d}", p.IdInfo.IdNum);
    }
}
