﻿using System;
using System.Globalization;

namespace udemy1
{

    class Program
    {


        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);



            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));










            /* string s = Console.ReadLine();

             string[] vet  = s.Split(' ');
             string p1 = vet[0];
             string p2 = vet[1];
             string p3 = vet[2];

             Console.WriteLine(p1);
             Console.WriteLine(p2);
             Console.WriteLine(p3);*/



            /*  string frase = Console.ReadLine();

             string x = Console.ReadLine();

             string y = Console.ReadLine();

             string z = Console.ReadLine();


             Console.WriteLine("Você digitou:");
             Console.WriteLine(frase);
             Console.WriteLine(x);
             Console.WriteLine(y);
             Console.WriteLine(z);*/
        }
    }
}
