![alt text][pattern]

- Algorithms may vary independently from clients using them.

# Intent
- Defines family of algorithms, encapsulates each one, and makes them interchangeable.

# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- In this example, different ducks may implement quacking behaviour differently.
- Therefore, quacking behaviours is separated into their own set of classes (the 'family of algorithms', or 'strategies').
- Different ducks may then choose which implementation of quacking to use (ducks are the clients).

## Program to an interface, not an implementation
- The Ducks classes (clients) do not implement the quacking behaviour.
- Instead, the **IQuacker** interface is used as an abstraction to represent the strategies (quacking behaviour).
- Quacking behaviour is implemented as a separate set of classes; Each class being a specific implementation of the behaviour.

## Favour composition over inheritance
- Each Duck class contains (is composed of) a Quacker classes.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Strategy/strategy.png "Stategy Pattern"