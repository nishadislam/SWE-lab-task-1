using sysytem;

namespace Vehicle
{
    using System;
    namespace OnlineClassTask
    {
        public class Vehicle
        {
            private string brand;
            private string model;
            private int year;


            public Vehicle()
            {
                Console.WriteLine("Vehicle default constructor called");
            }


            public Vehicle(string brand, string model, int year)
            {
                this.brand = brand;
                this.model = model;
                this.year = year;
                Console.WriteLine("Vehicle parameterized constructor called");
            }


            public void SetBrand(string brand)
            {
                this.brand = brand;
            }

            public void SetModel(string model)
            {
                this.model = model;
            }

            public void SetYear(int year)
            {
                this.year = year;
            }

            public string GetBrand()
            {
                return brand;
            }

            public string GetModel()
            {
                return model;
            }

            public int GetYear()
            {
                return year;
            }


            public virtual void ShowDetails()
            {
                Console.WriteLine(" Vehicle Details ");
                Console.WriteLine("Brand: " + brand);
                Console.WriteLine("Model: " + model);
                Console.WriteLine("Year: " + year);
            }
        }
    }

}

