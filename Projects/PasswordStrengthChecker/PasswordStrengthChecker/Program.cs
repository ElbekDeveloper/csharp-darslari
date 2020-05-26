using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
           const int minLength = 8;

            // This will the return 
            // the digit characters 
            var digitsRx = new Regex(@"[0-9]");
            // This will the return 
            // the lowercase alphabet 
            Regex lowercaseRx = new Regex(@"[a-z]");
            // This will the return 
            // the uppercase alphabet 
            Regex uppercaseRx = new Regex(@"[A-Z]");

            // This will the return 
            // the characters 
            Regex symbolsRx = new Regex(@"[!-/]");

            int score = 0;
            // user input password
            Console.Write("Please, insert password: ");
            string userPassword = Console.ReadLine();

            score += (userPassword.Length >= minLength) ? 1 : 0;

            Match matchUppercase = uppercaseRx.Match(userPassword);
            score += (matchUppercase.Success) ? 1 : 0;

           /* if (userPassword.Length >= minLength)
            {
                score++;
            }*/
           /* if (matchUppercase.Success)
            {
                Console.WriteLine("Uppercase added");
                score++;
            }*/
            Match matchLowercase = lowercaseRx.Match(userPassword);
            if (matchLowercase.Success)
            {
                Console.WriteLine("Lowercase added");
                score++;
            }

            Match matchDigits = digitsRx.Match(userPassword);
            if (matchDigits.Success)
            {
                Console.WriteLine("Digits added");
                score++;
            }
            Match matchSymbols = symbolsRx.Match(userPassword);
            if (matchSymbols.Success)
            {
                Console.WriteLine("Symbols added");
                score++;
            }
            // tell the user the strength
            switch (score)
            {
                case 4:
                case 5:
                    Console.WriteLine("Extremely Strong!");
                    break;
                case 3:
                    Console.WriteLine("Strong!");
                    break;
                case 2:
                    Console.WriteLine("Medium!");
                    break;
                case 1:
                    Console.WriteLine("Weak!");
                    break;
                default:
                    Console.WriteLine("Invalid Password!");
                    break;

            }




        }
    }
}