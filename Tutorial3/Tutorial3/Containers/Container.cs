using Tutorial3.Exceptions;
using Tutorial3.Interfaces;

namespace Tutorial3;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }
    public double Height { get; set; }

    protected Container(double cargoWeight, double height)
    {
        CargoWeight = cargoWeight;
        Height = height;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        
        throw new OverfillException();
    }
}