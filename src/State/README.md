![alt text][pattern]

- State Pattern allows an object to alter its behaviour when its internal state changes.
- States are encapsulated into separate classes and delegates behaviour to the object representing the current state.

# Intent
- Encapsulate behaviours within state objects to avoid adding excessive conditional code within a context.

# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- Behaviours vary depending on an object's state.

## Program to an interface, not an implementation
- IState provides the interface for discrete state classes.

## Favour composition over inheritance
- A State machine is composed of IState objects. Each IState object contains a reference back to the State machine.

[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/State/state.png "State Pattern"
