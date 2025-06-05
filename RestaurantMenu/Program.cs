using Model.Core;
using Model.Data;
using Newtonsoft.Json;
using RestaurantMenu;
using System;
using System.Windows.Forms;

namespace RestaurantMenu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());


            ////// Используем класс из Model
            ////var menu = new Menu("Основное меню");
            ////menu.AddDish(new Drink("Кофе", 5.99m));

            ////// Используем сериализатор из Model
            ////var serializer = new Json();
            ////serializer.Serialize(menu, "menu.json");

            ////Console.WriteLine("Готово! Проверьте файл menu.json");



            //var menu = new Menu("Основное");
            //menu.AddDish(new Drink("Чай", 3.99m));

            //var cafe = new Cafe("Кафе 'Уют'");

            //// 2. Сериализация в JSON (базовый уровень)
            //var jsonSerializer = new Json();
            //jsonSerializer.Serialize(cafe, "cafe.json");

            //// 3. Сериализация в XML (базовый уровень)
            //var xmlSerializer = new Xml();
            //xmlSerializer.Serialize(cafe, "cafe.xml");

            //// 4. Загрузка (проверка)
            //var loadedCafe = jsonSerializer.Deserialize<Cafe>("cafe.json");
            //Console.WriteLine($"Загружено: {loadedCafe.Name}");
        }
    }
}