![alt text][pattern]

- Simple Factory is not so much a design pattern; Rather, it's a programming idiom.
- A class which uses a Simple Factory is the Client.
- Rather than directly instantiating Product classes, the instantiation is delegated to a Simple Factory class.
- The Simple Factory should be the only part of the application which refers directly to concrete Product classes.
- Concrete Products implement the Product abstraction (abstract class or interface).


# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- The Product classes being created.

## Program to an interface, not an implementation
- The Product class represents the abstraction (abstract class or interface).
- Clients never directly reference or create concrete Product classes themselves.

## Favour composition over inheritance
- Each Client contains (is composed of) a Simple Factory class.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Simple.Factory/simpleFactory.png "Simple Factory Pattern"