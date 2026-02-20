
using Vehicle;
using System;

public class Program
{
    public static void Main(string[] args)
    {

        Car c1 = new Car();
        c1.SetBrand("Toyota");
        c1.SetModel("Corolla");
        c1.SetYear(2022);
        c1.SetFuelType("Petrol");
        c1.ShowDetails();

        Vehicle v = new Vehicle("Truckor", "M90", 2021);
        v.ShowDetails();


        Car c2 = new Car("Tesla", "Model 3", 2024, "Electric");
        c2.ShowDetails();
        c2.UpdateFuelType("Hybrid");
        c2.UpdateFuelType("Electric", " back to original type");
        c2.ShowDetails();

        Vehicle v1 = new Car("cypertruck", "T3", 2022, "Electric");
        v1.ShowDetails();

        Vehicle v2 = new Car("Honda", "Civic", 2023, "Diesel");
        v2.ShowDetails();
    }
}