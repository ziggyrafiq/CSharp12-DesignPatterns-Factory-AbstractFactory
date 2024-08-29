using FactoryAndAbstractFactoryDemo;

Console.WriteLine("Hello, from Ziggy Rafiq!");
// Client usage with Concrete Factory A
IFactory factoryA = new ConcreteFactoryA();
Client clientA = new Client(factoryA);
Console.WriteLine(clientA.ClientCode());

// Client usage with Concrete Factory B
IFactory factoryB = new ConcreteFactoryB();
Client clientB = new Client(factoryB);
Console.WriteLine(clientB.ClientCode());
