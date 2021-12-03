![alt text][pattern]

- Factory Method Pattern encapsulates object creation by letting subclasses decide what object to create.
- The Abstract Creator class defines an abstract factory method that subclasses must implement to product products.
- Creator subclasses are called Concrete Creator classes.
- For every Concrete Creator, there's typically a whole set of Concrete Products it creates.
- Parameterized factory methods can create more than one object based on a parameter.
- Factory methods can also not be parameterized, and just create one type of object.
- Differs from Simple Factory pattern in that, Factory Method is creating a framework that lets subclasses decide which implementation to use.
- In comparison, Simple Factory gives a way to encapsulate object creation, but doesn't have the flexibility to vary the products being created.

# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- The Product classes being created.

## Program to an interface, not an implementation
- The Product class represents the abstraction (abstract class or interface).
- Clients never directly reference or create concrete Product classes themselves.

## Favour composition over inheritance
- Each Client contains (is composed of) a Factory class.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Factory.Method.Pattern/factoryMethodPattern.png "Factory Method Pattern"