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


            ////// ���������� ����� �� Model
            ////var menu = new Menu("�������� ����");
            ////menu.AddDish(new Drink("����", 5.99m));

            ////// ���������� ������������ �� Model
            ////var serializer = new Json();
            ////serializer.Serialize(menu, "menu.json");

            ////Console.WriteLine("������! ��������� ���� menu.json");



            //var menu = new Menu("��������");
            //menu.AddDish(new Drink("���", 3.99m));

            //var cafe = new Cafe("���� '���'");

            //// 2. ������������ � JSON (������� �������)
            //var jsonSerializer = new Json();
            //jsonSerializer.Serialize(cafe, "cafe.json");

            //// 3. ������������ � XML (������� �������)
            //var xmlSerializer = new Xml();
            //xmlSerializer.Serialize(cafe, "cafe.xml");

            //// 4. �������� (��������)
            //var loadedCafe = jsonSerializer.Deserialize<Cafe>("cafe.json");
            //Console.WriteLine($"���������: {loadedCafe.Name}");
        }
    }
}