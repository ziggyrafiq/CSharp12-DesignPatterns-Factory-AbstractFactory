# C# 12 Design Patterns: Factory and Abstract Factory (CSharp12-DesignPatterns-Factory-AbstractFactory)

## Overview
In this repository, you will find examples of Factory and Abstract Factory design patterns in C# 12. These patterns simplify creating complex objects and enhance code maintainability, scalability, and overall navigation.  

 **[Article published on C# Corner click here to read this article](https://www.c-sharpcorner.com/article/c-sharp-12-design-patterns-factory-and-abstract-factory/)**

## Key Concepts

### Factory Pattern
Factory patterns encapsulate object creation, allowing clients to create objects without specifying their exact class. They facilitate loose coupling and simplify object management.

**Components:**
- `IProduct`: Interface for products.
- `ConcreteProductA` & `ConcreteProductB`: Specific product implementations.
- `IFactory`: Interface for the factory method.
- `ConcreteFactoryA` & `ConcreteFactoryB`: Specific factory implementations.
- `Client`: Uses the factory to create products.

### Abstract Factory Pattern
It facilitates the management of product variations because it allows families of related objects to be used together, extending the Factory Pattern.

**Components:**
- Interfaces and concrete classes similar to those in the Factory Pattern, adapted to support multiple product families.

## Implementation

### Running the Example

To see the Factory Pattern in action:
1. Clone the repository: `git clone https://github.com/ziggyrafiq/CSharp12-DesignPatterns-Factory-AbstractFactory.git`
2. Open the solution in Visual Studio.
3. Build and run the project to see how different factories create specific products.

### Example Code

```csharp
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

```

## About The Author Ziggy Rafiq

Ziggy Rafiq works as a Technical Lead Developer and is a prominent public figure in the tech industry and developer community. With over 20 years of experience as a Full-Stack Designer, Developer, Tester, DevSecOps, Technical Architect,
Software Project Manager, and expert in Agile Management Best Practices and Standards, Ziggy is widely respected for his knowledge and skills. He is also an author, regularly contributing articles
to [C# Corner](https://www.c-sharpcorner.com/members/ziggy-rafiq), and [Geek Coding](https://geek-coding.com/members/ziggy-rafiq) to
share his expertise and wisdom with a global audience. Ziggy also has a YouTube Channel where he creates content based on his experience to help and inspire other developers, designers, testers, project managers,
technical architects, and Agile Scrum masters.

- **Technical Lead Developer, Mentor and Trainer**
- **[C# Corner (MVP 🏅, VIP⭐️, Public Speaker🎤)](https://www.c-sharpcorner.com/members/ziggy-rafiq)**
- **[Geek Coding Writter](https://geek-coding.com/members/ziggy-rafiq)**
- **[Technology Manager Writter](https://technology-manager.com/members/ziggy-rafiq)**
- Link to [**Ziggy Rafiq Blog**](https://blog.ziggyrafiq.com)
- Link to [**Ziggy Rafiq Website**](https://ziggyrafiq.com)

* [**Please remember to subscribe to My YouTube channel**](https://www.youtube.com/)
* [**Please remember to follow me on LinkedIn**](https://www.linkedin.com/in/ziggyrafiq/)
* [**Please remember to follow me on Twitter/X**](https://twitter.com/ziggyrafiq)
* [**Please remember to follow me on Instagram**](https://www.instagram.com/ziggyrafiq/)
* [**Please remember to follow me on Facebook**](https://www.facebook.com/ziggyrafiq)

## Contributing

Any improvements or corrections should be submitted as a pull request or opened in an issue.

## License

The LICENSE file contains details about how this project is licensed under the MIT License.
