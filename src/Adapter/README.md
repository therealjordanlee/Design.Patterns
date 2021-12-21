![alt text][pattern]

The Adapter Pattern converts the interfaace of a class into another interface the client expects.
Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

# Intent
- Converts one interface to another.

# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- Adapter Pattern acts as a conversion layer that translates between 2 incompatible interfaces.

## Program to an interface, not an implementation
- The Adapter implements the Target interface.

## Favour composition over inheritance
- The Adapter is composed of the Adaptee.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Adapter/adapter.png "Adapter Pattern"