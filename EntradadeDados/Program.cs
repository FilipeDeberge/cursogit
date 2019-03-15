using System;

namespace EntradadeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();
            Console.WriteLine("Digite uma cor:");
            string x = Console.ReadLine();
            Console.WriteLine("Digite uma cor:");
            string y = Console.ReadLine();
            Console.WriteLine("Digite uma cor:");
            string z = Console.ReadLine();
            Console.WriteLine("Digite três cores separadas por espaço:");
            

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2]; 

            


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            
        }
    }
}
