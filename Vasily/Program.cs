using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // 1. Задача с числовым шифром
        int[] cipher = { 8, 5, 12, 12, 15 };
        string word = "";
        foreach (int number in cipher)
        {
            word += (char)(number + 64);
        }
        Console.WriteLine($"Шифр: {word}");

        // 2. Масив-чудо
        int[] array = { 3, 5, 2, 7, 9 };
        int[] result = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            if (IsPrime(i))
            {
                result[i] = array[i] * 2;
            }
            else
            {
                result[i] = array[i] * i;
            }
        }
        Console.WriteLine($"Масив-чудо: {string.Join(", ", result)}");

        // 3. Поиск минимального разрыва
        int[] numbers = { 10, 2, 5, 12, 7 };
        int minDiff = int.MaxValue;
        int[] minPair = new int[2];
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int diff = Math.Abs(numbers[i] - numbers[i + 1]);
            if (diff < minDiff)
            {
                minDiff = diff;
                minPair[0] = i;
                minPair[1] = i + 1;
            }
        }
        Console.WriteLine($"Мінімальний розрив: {string.Join(", ", minPair)}");

        // 4. Два масиви — два супротивники
        int[] array1 = { 10, 20, 30 };
        int[] array2 = { 15, 10, 40 };
        int[] diffArray = new int[array1.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            int diff = array1[i] - array2[i];
            diffArray[i] = diff < 0 ? 0 : diff;
        }
        Console.WriteLine($"Різниця масивів: {string.Join(", ", diffArray)}");

        // 5. Масив для шифра Цезаря
        char[] text = { 'A', 'B', 'C' };
        int shift = 3;
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                text[i] = (char)((text[i] - 'A' + shift) % 26 + 'A');
            }
        }
        Console.WriteLine($"Шифр Цезаря: {string.Join("", text)}");

        // 6. Масив як карта висот
        int[] heights = { 1, 3, 2, 4, 1, 5 };
        List<int> peaks = new List<int>();

        for (int i = 1; i < heights.Length - 1; i++)
        {
            if (heights[i] > heights[i - 1] && heights[i] > heights[i + 1])
            {
                peaks.Add(heights[i]);
            }
        }
        Console.WriteLine($"Піки: {string.Join(", ", peaks)}");

        // 7. Видалити елемент масиву за індексом
        int[] nums = { 1, 3, 2, 4, 1, 5 };
        int indexToRemove = 2;
        List<int> newNums = new List<int>(nums);
        newNums.RemoveAt(indexToRemove);
        Console.WriteLine($"Масив після видалення: {string.Join(", ", newNums)}");

        // 8. Сума двох елементів
        int[] sortedArray = { 1, 2, 4, 7, 9, 11 };
        int targetSum = 11;
        for (int i = 0; i < sortedArray.Length; i++)
        {
            for (int j = i + 1; j < sortedArray.Length; j++)
            {
                if (sortedArray[i] + sortedArray[j] == targetSum)
                {
                    Console.WriteLine($"Індекси: {i}, {j}");  // Рішення: [1, 4]
                    break;
                }
            }
        }

        // 9. Генерація відсортованого масиву випадкових чисел
        Random random = new Random();
        int length = 5;
        int min = 0, max = 10;
        List<int> randomList = new List<int>();

        for (int i = 0; i < length; i++)
        {
            randomList.Add(random.Next(min, max + 1));
        }
        randomList.Sort();
        Console.WriteLine($"Випадковий відсортований масив: {string.Join(", ", randomList)}");

        // 10. Генерація масиву випадкових унікальних чисел
        HashSet<int> uniqueRandomSet = new HashSet<int>();
        while (uniqueRandomSet.Count < length)
        {
            uniqueRandomSet.Add(random.Next(min, max + 1));
        }
        List<int> uniqueRandomList = new List<int>(uniqueRandomSet); Console.WriteLine($"Унікальні випадкові числа: {string.Join(", ", uniqueRandomList)}");

        // 11. Перші N чисел Фібоначчі
        int n = 5;
        List<int> fibonacci = new List<int> { 1, 2 };
        for (int i = 2; i < n; i++)
        {
            fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
        }
        Console.WriteLine($"Числа Фібоначчі: {string.Join(", ", fibonacci)}");
    }

    // Перевірка простого числа
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

}