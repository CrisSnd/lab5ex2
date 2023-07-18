using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom.*/


            Console.WriteLine("Introduceti sirul de caractere: ");
            string text = (Console.ReadLine());

            string textInversat="";

            for (int i= text.Length-1;i>=0;i--)
            {
                textInversat = textInversat + text[i];
            }

            if (text == textInversat)
            {
            Console.WriteLine("\n"+ $"Textul {text} este palindrom. ");
            }
            else 
            {
             Console.WriteLine("\n"+ $"Textul {text} nu este palindrom. ");
            }

        }

    }

}


