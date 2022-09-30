using System;

namespace Вас
{
    internal class Program
    {
        
        static string numbers = "123456789";
        static string letters = "QWERTYRIUYOUIPYZXCVBNMKJIOLPD";

        static char generate_random_letter()
        {
            Random rnd = new Random();
            return letters[rnd.Next(letters.Length)];

        }
        static char generate_random_number()
        {
            Random rnd = new Random();
            return numbers[rnd.Next(numbers.Length)];
        }

        public static void Main(string[] args)
        {
            int password_length = 10;
            string password = "";
            

            for (int i = 0; i < password_length; i++)
            {
                if( i % 2 == 0)
                {
                    password += generate_random_letter();

                }
                else
                {
                    password += generate_random_number();
                }
                Console.WriteLine("Пароль");
                Console.WriteLine(password);
            }
        }

    }
}
