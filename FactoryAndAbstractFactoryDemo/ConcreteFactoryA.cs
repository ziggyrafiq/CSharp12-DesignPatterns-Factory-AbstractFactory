// Concrete Factory A
namespace FactoryAndAbstractFactoryDemo;
public class ConcreteFactoryA : IFactory
{
    public IProduct CreateProduct()
    {
        return new ConcreteProductA();
    }
}
