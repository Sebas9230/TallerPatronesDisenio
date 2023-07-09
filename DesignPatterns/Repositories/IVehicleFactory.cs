using DesignPatterns.Models;

namespace DesignPatterns.Repositories
{
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle(string color);
    }
}
