![alt text][pattern]

- The Decorator Pattern involves a set of decorator classes that 'wrap' concrete components.
- Decorator classes are the same type as the components they decorate (can be either through inheritance or interfaces).
- Multiple decorators can wrap a component.
- Is typically transparent to clients using the component (unless the client relies on a component's concrete type).

# Intent
- Doesn't alter the interface, but adds additional functionality/responsibilities.

# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- The behaviour you are trying to extend to an existing class.
- You can add or modify behaviour by adding additional Decorator classes, without having to change the original component.

## Program to an interface, not an implementation
- Decorator classes mirror a component's type (either through inheritance or interface).

## Favour composition over inheritance
- Decorator classes work by wrapping a component. This is inherently composition.
- Where inheritance is used, it is done purely to achieve 'type binding'. The actual behaviour modification is achieve through composition.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Decorator/decorator.png "Decorator Pattern"