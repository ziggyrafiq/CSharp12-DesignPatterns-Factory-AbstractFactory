// Concrete Factory B
namespace FactoryAndAbstractFactoryDemo;
public class ConcreteFactoryB : IFactory
{
    public IProduct CreateProduct()
    {
        return new ConcreteProductB();
    }
}
