![alt text][pattern]

The Command Pattern encapsulates a request as an object, thereby letting you parameterize other objects with different requests, queue or log requests, and support undoable operations.

- Decouples an object making a request from the object performing it.
- Command objects encapsulate a receiver.
- Receivers contain the action (or set of actions) which must be executed when a Command is executed.
- Invokers store Commands, and may execute them by calling the Command's _Execute()_ method.

# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- A client may need to call a number of different objects, none of which share a common interface (the receivers).
- Receiver actions are what varies.
- The Command interface provides an abstraction layer to decouple the client from having to know anything about Receiver actions.

## Program to an interface, not an implementation
- Commands all implement an ICommand interface.

## Favour composition over inheritance
- Commands are composed of a receiver, which performs the actual work.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Command/command.png "Command Pattern"