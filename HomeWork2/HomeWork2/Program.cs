using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Лада", "D");
            car.Color = Color.Purple;

            try
            {
                Console.WriteLine("Владелец - " + car.CarPassport.Owner.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Имя владельца лады не задано!");
            }

            var driver = new Driver("23.11.2015", "Вольдемар");
            driver.Category = "BC";

            try
            {
                car.ChangeOnwer("o777oo", driver);
            }
            catch (Exception)
            {
                
                Console.WriteLine("Ошибка!");
            }

            driver.Category += "D";
            car.ChangeOnwer("o777oo", driver);

            Console.WriteLine("Владелец машины: " + driver.Name);
            Console.WriteLine("Номер машины: " + car.CarNumber);

            Console.ReadKey();
        }
    }
}
