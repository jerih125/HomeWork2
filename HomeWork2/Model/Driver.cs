using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public string LicenseDate { get; }

        public string Name { get; }

        public string Expirience { get; set; }

        public string Category { get; set; }

        public Car Car { get; private set; }

        public Driver(string licensedate, string name)
        {
            LicenseDate = licensedate;

            Name = name;
        }

        public void OwnCar(Car car)
        {
            if (Category.Contains(car.Category))
            {
                Car = car;
            }
            else
            {
                Console.WriteLine("Категория водителя не подходит к категории автомобиля");
            }
        }
    }
}
