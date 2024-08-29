namespace FactoryAndAbstractFactoryDemo;

public class Client
{
    private readonly IFactory _factory;

    public Client(IFactory factory)
    {
        _factory = factory;
    }

    public string ClientCode()
    {
        var product = _factory.CreateProduct();
        return product.Operation();
    }
}
