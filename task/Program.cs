namespace task
{
    /// <summary>
    /// Методы агрегирования
    ///
    /// 1) Выбрать товары категории Mobile, цена которых превышает 1000 грн.
    /// 2) Вывести название и цену тех товаров, которые не относятся к категории Kitchen, цена которых превышает 1000 грн.
    /// 3) Вычислить среднее значение всех цен товаров.
    /// 4) Вывести список категорий без повторений.
    /// 5) Вывести названия и категории товаров в алфавитном порядке, упорядоченных по названию.
    /// 6) Посчитать суммарное количество товаров категорий Сar и Mobile.
    /// 7) Вывести список категорий и количество товаров каждой категории. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Good> goods1 = new List<Good>()
            {
                new Good()
                    { Id = 1, Title = "Nokia 1100", Price = 450.99, Category = "Mobile" },
                new Good()
                    { Id = 2, Title = "Iphone 4", Price = 5000, Category = "Mobile" },
                new Good()
                    { Id = 3, Title = "Refregirator 5000", Price = 2555, Category = "Kitchen" },
                new Good()
                    { Id = 4, Title = "Mixer", Price = 150, Category = "Kitchen" },
                new Good()
                    { Id = 5, Title = "Magnitola", Price = 1499, Category = "Car" },
                new Good()
                    { Id = 6, Title = "Samsung Galaxy", Price = 3100, Category = "Mobile" },
                new Good()
                    { Id = 7, Title = "Auto Cleaner", Price = 2300, Category = "Car" },
                new Good()
                    { Id = 8, Title = "Owen", Price = 700, Category = "Kitchen" },
                new Good()
                    { Id = 9, Title = "Siemens Turbo", Price = 3199, Category = "Mobile" },
                new Good()
                    { Id = 10, Title = "Lighter", Price = 150, Category = "Car" }
            };

            //  
        }
        

    }
}