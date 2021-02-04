/***********************************************************************************************
 * Übungsnr:        06                                     
 * Programmname:    PrimeNumbers                                  
 * Autor:           Michael Bucek                                
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Der Benutzer wird aufgefordert, eine Zahl einzugeben.
 * Das Programm ermittelt, ob es sich dabei um eine Primzahl handelt
 * ************************************************
*/
using System;
namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isPrime=false;
            bool isDivisible=false;
            
            //Zahl einlesen
            Console.WriteLine("Primzahlrechner!");
            Console.Write("Geben Sie eine Zahl ein:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                 //Schleife zur Ermittlung ob es einen Teiler größer 1 und kleiner der Zahl gibt -> dann keine Primzahl
                isDivisible=false;
                for (int divisor = 2; divisor < number; divisor++)
                {
                    if (number%divisor==0)
                    {
                        isDivisible = true;
                        break;
                    }
                }
                isPrime = !isDivisible;
            }

            //Ausgabe des Ergebnisses
            if (isPrime == true)
            {
                Console.WriteLine("Primzahl!");
            }
            else
            {
                Console.WriteLine("Keine Primzahl!");
            }
        }
    }
}
