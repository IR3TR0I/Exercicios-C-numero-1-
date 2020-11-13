using System;

namespace Exercicios_Condicionais_C__Tarde
{
    class Program
    {
        static void Main(string[] args)
        {  
            float Meses, Dias, Horas, Minutos;

            Console.WriteLine("------------------");
            Console.WriteLine("Digite a sua idade");
            Console.WriteLine("------------------");

            int idade = int.Parse(Console.ReadLine());

            //processamento 

            Meses = (idade*12);
            Dias  = (idade*365);
            Horas = (idade*8760);
            Minutos = (idade*525600);


            //saida de dados 

            Console.WriteLine("Você viveu "+Meses+" Meses, "+Dias+" dias, "+Horas+" horas, "+Minutos+" e minutos.");


        }
    }
}
