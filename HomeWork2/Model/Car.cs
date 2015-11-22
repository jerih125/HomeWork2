using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Car
    {
        public string Model { get; }

        public Color Color { get; set; } = Color.Blue;

        public string CarNumber { get; private set; }

        public string Category { get; }

        public CarPassport CarPassport { get; }

        public Car(string model, string category)
        {
            Category = category;
            Model = Model;
            CarPassport = new CarPassport(this);
        }

        public void ChangeOnwer(string carNumber, Driver name)
        {
            CarNumber = carNumber;
            CarPassport.Owner = name;
            name.OwnCar(this);
        }
    }
}
