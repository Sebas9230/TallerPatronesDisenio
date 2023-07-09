using DesignPatterns.Models;
using DesignPatterns.Repositories;

public class FordVehicleFactory : IVehicleFactory
{
    public Vehicle CreateVehicle(string color)
    {
        return new CarBuilder()
            .SetBrand("Ford")
            .SetModel("Escape")
            .SetColor(color)
            .Build();
    }
}
