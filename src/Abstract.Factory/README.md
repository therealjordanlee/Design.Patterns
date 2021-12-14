![alt text][pattern]

- Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.
- Provides an interface for creating a family of products.
- Allows for implementing a variety of products meant for different contexts (e.g. regions, operating systems, 'look and feels').
- Code is decoupled from actual products, so different factories can be substituted to get different behaviours.
- Relies on object composition: object creation is implemented in methods exposed in the factory interface.


# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- The Product classes being created.

## Program to an interface, not an implementation
- The abstract factory provides an abstraction for creating different families of products.
- Clients never directly reference or create concrete Product classes themselves.
- Different implementations of the Abstract Factory can be substituted to get different behaviours.

## Favour composition over inheritance
- Each Client contains (is composed of) an implementation of the Abstract Factory class.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Abstract.Factory/abstractFactoryPattern.png "Abstract Factory Pattern"