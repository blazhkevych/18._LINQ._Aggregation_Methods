namespace task;

/// <summary>
///     Методы агрегирования
///     1) Выбрать товары категории Mobile, цена которых превышает 1000 грн.
///     2) Вывести название и цену тех товаров, которые не относятся к категории Kitchen, цена которых превышает 1000 грн.
///     3) Вычислить среднее значение всех цен товаров.
///     4) Вывести список категорий без повторений.
///     5) Вывести названия и категории товаров в алфавитном порядке, упорядоченных по названию.
///     6) Посчитать суммарное количество товаров категорий Сar и Mobile.
///     7) Вывести список категорий и количество товаров каждой категории.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        var goods1 = new List<Good>
        {
            new() { Id = 1, Title = "Nokia 1100", Price = 450.99, Category = "Mobile" },
            new() { Id = 2, Title = "Iphone 4", Price = 5000, Category = "Mobile" },
            new() { Id = 3, Title = "Refregirator 5000", Price = 2555, Category = "Kitchen" },
            new() { Id = 4, Title = "Mixer", Price = 150, Category = "Kitchen" },
            new() { Id = 5, Title = "Magnitola", Price = 1499, Category = "Car" },
            new() { Id = 6, Title = "Samsung Galaxy", Price = 3100, Category = "Mobile" },
            new() { Id = 7, Title = "Auto Cleaner", Price = 2300, Category = "Car" },
            new() { Id = 8, Title = "Owen", Price = 700, Category = "Kitchen" },
            new() { Id = 9, Title = "Siemens Turbo", Price = 3199, Category = "Mobile" },
            new() { Id = 10, Title = "Lighter", Price = 150, Category = "Car" }
        };

        // Выбрать товары категории Mobile, цена которых превышает 1000 грн.
        var result1 = goods1.Where(g => g.Category == "Mobile" && g.Price > 1000);
        // Вывести в консоль.
        Console.WriteLine("1) Выбрать товары категории Mobile, цена которых превышает 1000 грн.");
        foreach (var good in result1) Console.WriteLine(good.Title);

        // Вывести название и цену тех товаров, которые не относятся к категории Kitchen, цена которых превышает 1000 грн.
        var result2 = goods1.Where(g => g.Category != "Kitchen" && g.Price > 1000);
        // Вывести в консоль.
        Console.WriteLine(
            "2) Вывести название и цену тех товаров, которые не относятся к категории Kitchen, цена которых превышает 1000 грн.");
        foreach (var good in result2) Console.WriteLine(good.Title + " " + good.Price);

        // Вычислить среднее значение всех цен товаров.
        var result3 = goods1.Average(g => g.Price);
        // Вывести в консоль.
        Console.WriteLine("3) Вычислить среднее значение всех цен товаров.");
        Console.WriteLine(result3);

        // Вывести список категорий без повторений.
        var result4 = goods1.Select(g => g.Category).Distinct();
        // Вывести в консоль.
        Console.WriteLine("4) Вывести список категорий без повторений.");
        foreach (var category in result4) Console.WriteLine(category);

        // Вывести названия и категории товаров в алфавитном порядке, упорядоченных по названию.
        var result5 = goods1.OrderBy(g => g.Title).Select(g => new { g.Title, g.Category });
        // Вывести в консоль.
        Console.WriteLine("5) Вывести названия и категории товаров в алфавитном порядке, упорядоченных по названию.");
        foreach (var good in result5) Console.WriteLine(good);

        // Посчитать суммарное количество товаров категорий Сar и Mobile.
        var result6 = goods1.Where(g => g.Category == "Car" || g.Category == "Mobile").Count();
        // Вывести в консоль.
        Console.WriteLine("6) Посчитать суммарное количество товаров категорий Сar и Mobile.");
        Console.WriteLine(result6);

        // Вывести список категорий и количество товаров каждой категории.
        var result7 = goods1.GroupBy(g => g.Category).Select(g => new { Category = g.Key, Count = g.Count() });
        // Вывести в консоль.
        Console.WriteLine("7) Вывести список категорий и количество товаров каждой категории.");
        foreach (var category in result7) Console.WriteLine(category);
    }
}