using System;
using System.Globalization;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //Task 1

        /*Console.WriteLine("Введіть розмір ставки(від 5$ до 100$, крок ставки 5$):");
        int bet;
        while (!int.TryParse(Console.ReadLine(), out bet) || bet < 5 || bet > 100 || bet % 5 != 0)
        {
            Console.WriteLine("Неправильна ставка. Введіть значення в діапазоні від 5$ до 100$:");
        }
        Random random = new Random();
        int[] reels = new int[3];
        for (int i = 0; i < reels.Length; i++)
        {
            reels[i] = random.Next(1, 10);
        }
        Console.WriteLine($"Ваша комбінація: {reels[0]}{reels[1]}{reels[2]}");
        double multiplier = CalculateMultiplier(reels);
        if(multiplier > 0)
        {
            double winnings = bet * multiplier;
            Console.WriteLine($"Вітаємо! Ви виграли {winnings:C}(коефіцієнт: {multiplier})");
        }
        else
        {
            Console.WriteLine("На жаль, ви програли. Спробуйте ще раз...");
        }
    }
    static double CalculateMultiplier(int[] reels)
    {
        if (reels[0] == reels[1] && reels[1] == reels[2])
        {
            switch (reels[0])
            {
                case 1: return 10 * 1.5;
                case 2: return 20 * 1.5;
                case 3: return 30 * 1.5;
                case 4: return 40 * 1.5;
                case 5: return 50 * 1.5;
                case 6: return 60 * 1.5;
                case 8: return 80 * 1.5;
                case 9: return 90 * 1.5;
                case 7: return 150 * 1.5;
            }
        }
        if (reels[0] == reels[1] || reels[1] == reels[2])
        {
            int matchedNumber = reels[1];
            switch (matchedNumber)
            {
                case 1: return 1 * 1.25;
                case 2: return 2 * 1.25;
                case 3: return 3 * 1.25;
                case 4: return 4 * 1.25;
                case 5: return 5 * 1.25;
                case 6: return 6 * 1.25;
                case 8: return 8 * 1.25;
                case 9: return 9 * 1.25;
                case 7: return 15 * 1.25;

            }
        }
        if (Array.Exists(reels, x => x == 7)) return 1.6;
        if (Array.Exists(reels, x => x == 9)) return 1.35;
        return 0;*/

        //Task 2;
        /* Console.WriteLine("Введіть число N:");
         int N;
         while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
         {
             Console.WriteLine("Будь ласка, введіть додатне ціле число:");
         }
         Console.WriteLine($"Числа Армстронга в діапазоні від 1 до {N}:");
         for (int i = 1; i <= N; i++)
         {
             if (IsArmstrong(i))
             {
                 Console.WriteLine(i);
             }
         }
     }
     static bool IsArmstrong(int number)
     {
         int sum = 0;
         int temp = number;
         int digitsCount = number.ToString().Length; 

         while (temp > 0)
         {
             int digit = temp % 10; 
             sum += (int)Math.Pow(digit, digitsCount); 
             temp /= 10; 
         }

         return sum == number;*/

        //Task 3

        /*Random random = new Random();
        string secretPassword = "";
        for (int i = 0; i < 4; i++)
        {
            secretPassword += random.Next(0, 10).ToString();
        }

        Console.WriteLine("Гра починається! Комп'ютер загадав пароль з 4-х цифр. Вгадайте його.");
        int attempts = 0;
        bool isGuessed = false;

        while (!isGuessed)
        {
            Console.Write("Введіть ваш пароль: ");
            string userGuess = Console.ReadLine();

            if (userGuess.Length != 4 || !int.TryParse(userGuess, out _))
            {
                Console.WriteLine("Пароль має складатися з 4-х цифр. Спробуйте ще раз.");
                continue;
            }

            string result = "";
            for (int i = 0; i < 4; i++)
            {
                if (userGuess[i] == secretPassword[i])
                {
                    result += userGuess[i]; 
                }
                else
                {
                    result += "Х";
                }
            }

           
            attempts++;

            Console.WriteLine($"Результат: {result}");

            if (result == secretPassword)
            {
                isGuessed = true;
                Console.WriteLine($"Ви вгадали пароль {secretPassword} за {attempts} спроб!");
            }
        }*/

        //Task 4

        Random random = new Random();
        string secretPassword = "";
        for (int i = 0; i < 4; i++)
        {
            secretPassword += random.Next(0, 10).ToString();
        }

        Console.WriteLine($"Комп'ютер загадав пароль. Починаємо автоматичний підбір...");
        Console.WriteLine($"Загаданий пароль: {secretPassword}");

        int attempts = 0;
        string currentGuess = "0000";

     
        while (currentGuess != secretPassword)
        {
            attempts++;
            currentGuess = GenerateNextGuess(currentGuess, secretPassword);
            Console.WriteLine($"Спроба {attempts}: {currentGuess}");
        }

        Console.WriteLine($"Пароль вгадано! {secretPassword} за {attempts} спроб.");
    }

    static string GenerateNextGuess(string currentGuess, string secretPassword)
    {
        char[] guess = currentGuess.ToCharArray();

        
        for (int i = 0; i < 4; i++)
        {
            if (guess[i] != secretPassword[i])
            {
                int currentDigit = (guess[i] - '0' + 1) % 10;
                guess[i] = currentDigit.ToString()[0];
                break; 
            }
        }

        return new string(guess);
    }
}
