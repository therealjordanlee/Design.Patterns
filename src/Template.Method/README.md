![alt text][pattern]

# Intent
- Template Method defines the steps of an algorithm, but allows subclasses to specify the implementation of some steps.

# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- A Template class defines the structure of an algorithm, but may allow parts of the algorithm to be altered by subclasses.
- This allows subclasses to create their own variations of an algorithm.

## Program to an interface, not an implementation
- An abstract class (the Template class) represents the interface.
- Algorithm behaviour is implemented as subclasses of the Template class; Each subclass being a specific implementation of the algorithm.

## Favour composition over inheritance
- Template Method Pattern relies on inheritence, rather than composition.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Template.Method/template.Method.png "Template Method Pattern"