using System;
using System.Globalization;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Введіть стать (чоловік/жінка): ");
        string gender = Console.ReadLine().Trim();

        Console.Write("Введіть ПІБ: ");
        string fullName = Console.ReadLine().Trim();

        Console.Write("Введіть вік: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Введіть вулицю: ");
        string street = Console.ReadLine().Trim();

        Console.Write("Введіть номер будинку: ");
        int houseNumber = int.Parse(Console.ReadLine());

        Console.Write("Введіть номер квартири: ");
        int apartmentNumber = int.Parse(Console.ReadLine());

        Console.Write("Введіть номер телефону: ");
        string phoneNumber = Console.ReadLine().Trim();

        Console.Write("Введіть електронну пошту: ");
        string email = Console.ReadLine().Trim();

        Console.Write("Введіть зріст (у метрах): ");
        double height = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);

        Console.Write("Введіть вагу (у кілограмах): ");
        double weight = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);

        Console.Write("Введіть групу крові: ");
        string bloodGroup = Console.ReadLine().Trim();

        Console.Write("Введіть улюблений колір: ");
        string favoriteColor = Console.ReadLine().Trim();

        Console.Write("Введіть улюблену страву: ");
        string favoriteFood = Console.ReadLine().Trim();

        Console.Write("Введіть хобі: ");
        string hobby = Console.ReadLine().Trim();

        Console.Write("Введіть улюблене місце для відпочинку: ");
        string favoriteVacationSpot = Console.ReadLine().Trim();

        Console.Write("Введіть улюблену пору року: ");
        string favoriteSeason = Console.ReadLine().Trim();

        Console.Write("Введіть улюблену тварину: ");
        string favoriteAnimal = Console.ReadLine().Trim();

        Console.Write("Введіть улюблену книгу: ");
        string favoriteBook = Console.ReadLine().Trim();

        Console.Write("Введіть улюблений фільм: ");
        string favoriteMovie = Console.ReadLine().Trim();

        Console.Write("Введіть улюблений вид спорту: ");
        string favoriteSport = Console.ReadLine().Trim();

        Console.Write("Введіть улюблений жанр музики: ");
        string favoriteMusicGenre = Console.ReadLine().Trim();

        Console.Write("Введіть місце роботи або навчання: ");
        string occupation = Console.ReadLine().Trim();

        Console.Write("Введіть назву рідного міста: ");
        string hometown = Console.ReadLine().Trim();

        Console.Write("Введіть дату народження (00.00.0000): ");
        string dateOfBirth = Console.ReadLine().Trim();

        Console.Write("Введіть ім’я улюбленого виконавця або гурту: ");
        string favoriteArtist = Console.ReadLine().Trim();

        Console.Write("Введіть улюблену цитату: ");
        string favoriteQuote = Console.ReadLine().Trim();

        Console.Write("Введіть улюблену країну: ");
        string favoriteCountry = Console.ReadLine().Trim();

        Console.Write("Введіть улюблений стиль одягу: ");
        string favoriteClothingStyle = Console.ReadLine().Trim();

        Console.Write("Введіть улюблену мову програмування: ");
        string favoriteProgrammingLanguage = Console.ReadLine().Trim();

        Console.Write("Введіть назву компанії, де хочете працювати: ");
        string dreamCompany = Console.ReadLine().Trim();

        Console.Write("Введіть кількість країн, які ви відвідали: ");
        int countriesVisited = int.Parse(Console.ReadLine());

        Console.Write("Введіть свою найбільшу мрію: ");
        string biggestDream = Console.ReadLine().Trim();

        Console.Write("Введіть улюблену (комп'ютерну) гру: ");
        string favoriteGame = Console.ReadLine().Trim();

        Console.WriteLine("\nВведені дані:");
        Console.WriteLine($"Стать: {gender}");
        Console.WriteLine($"ПІБ: {fullName}");
        Console.WriteLine($"Вік: {age}");
        Console.WriteLine($"Адреса: вул. {street}, буд. {houseNumber}, кв. {apartmentNumber}");
        Console.WriteLine($"Телефон: {phoneNumber}");
        Console.WriteLine($"Електронна пошта: {email}");
        Console.WriteLine($"Зріст: {height} м");
        Console.WriteLine($"Вага: {weight} кг");
        Console.WriteLine($"Група крові: {bloodGroup}");
        Console.WriteLine($"Улюблений колір: {favoriteColor}");
        Console.WriteLine($"Улюблена страва: {favoriteFood}");
        Console.WriteLine($"Хобі: {hobby}");
        Console.WriteLine($"Улюблене місце для відпочинку: {favoriteVacationSpot}");
        Console.WriteLine($"Улюблена пора року: {favoriteSeason}");
        Console.WriteLine($"Улюблена тварина: {favoriteAnimal}");
        Console.WriteLine($"Улюблена книга: {favoriteBook}");
        Console.WriteLine($"Улюблений фільм: {favoriteMovie}");
        Console.WriteLine($"Улюблений вид спорту: {favoriteSport}");
        Console.WriteLine($"Улюблений жанр музики: {favoriteMusicGenre}");
        Console.WriteLine($"Місце роботи або навчання: {occupation}");
        Console.WriteLine($"Рідне місто: {hometown}");
        Console.WriteLine($"Дата народження: {dateOfBirth}");
        Console.WriteLine($"Улюблений виконавець або гурт: {favoriteArtist}");
        Console.WriteLine($"Улюблена цитата: {favoriteQuote}");
        Console.WriteLine($"Улюблена країна: {favoriteCountry}");
        Console.WriteLine($"Улюблений стиль одягу: {favoriteClothingStyle}");
        Console.WriteLine($"Улюблена мова програмування: {favoriteProgrammingLanguage}");
        Console.WriteLine($"Компанія мрії: {dreamCompany}");
        Console.WriteLine($"Кількість відвіданих країн: {countriesVisited}");
        Console.WriteLine($"Найбільша мрія: {biggestDream}");
        Console.WriteLine($"Улюблена гра: {favoriteGame}");
    }
}