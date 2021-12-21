![alt text][pattern]

- The Facade Pattern provides a unified interfaace to a set of interfaces in a subsystem.
- Defines a high-level interface that makes the subsystem easier to use.

# Intent
- Provide a simpler interface for interacting with a complex system (or group of subsystems).

# Design Principles
## Program to an interface, not an implementation
- A Facade interface provides a simplifier interface for interacting with a more complex system (or subsystems).
- Decouples a client from a subsystem of components.

## Favour composition over inheritance
- Facade classes are composed of the system (or subsystems) they are intending to simplify.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Facade/facade.png "Facade Pattern"