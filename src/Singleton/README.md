![alt text][pattern]

Singleton Pattern:
- Ensures at most one instance of a class is instantiated in an application.
- Provides global access point to that instance.
- Is useful in very specific situations (e.g. object reading/writing to the registry).

# Design Principles
The Singleton Pattern violates a number of design principles:

## Loose coupling between objects that interact
- A change to the Singleton will require a change to every object using it.

## Single Responsibility Principle
- The Singleton is responsible for both managing its one instance as well as its main functionality.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Singleton/singleton.png "Singleton Pattern"