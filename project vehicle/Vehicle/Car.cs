using System;
namespace Vehicle
{
    public class Car : Vehicle
    {
        private string fuelType;


        public Car() : base()
        {
            Console.WriteLine("Car default constructor called");
        }


        public Car(string brand, string model, int year, string fuelType) : base(brand, model, year)
        {
            this.fuelType = fuelType;
            Console.WriteLine("Car parameterized constructor called");
        }


        public void SetFuelType(string fuelType)
        {
            this.fuelType = fuelType;
        }

        public string GetFuelType()
        {
            return fuelType;
        }


        public void UpdateFuelType(string newFuel)
        {
            this.fuelType = newFuel;
            Console.WriteLine("Fuel type updated using one parameter.");
        }

        public void UpdateFuelType(string newFuel, string note)
        {
            this.fuelType = newFuel;
            Console.WriteLine("Fuel type updated with note: " + note);
        }


        public override void ShowDetails()
        {
            Console.WriteLine("Car Details ");
            Console.WriteLine("Brand: " + GetBrand());
            Console.WriteLine("Model: " + GetModel());
            Console.WriteLine("Year: " + GetYear());
            Console.WriteLine("Fuel Type: " + fuelType);
        }
    }
}