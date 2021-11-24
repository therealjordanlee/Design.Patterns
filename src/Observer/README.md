![alt text][pattern]

- The Observer Pattern defines a 1:Many relationship.
- Subjects update Observers using a common interface.
- Observers of any concrete type can participate as long as they implement the Observer interface.
- Observers are loosely coupled in that the Subject knows nothing about them, other than that they implement the Observer interface.
- You can push or pull data from the Subject in this pattern (pull is considered more correct)
- Observer Pattern is related to **Publish/Subscribe Pattern** (which is for more complex situations with multiple subjects and/or multiple message types)

# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- The thing that varies is the state of the Subject and number/type of Observers.
- You can vary the objects which are dependent on the Subject's state, without having to change the Subject.

## Program to an interface, not an implementation
- Both Subject & Observers are interfaces.
- Subject keeps track of Observers.
- Observers register with and get notified by Subject interface.
- This keeps Subject loosely coupled with Observers.

## Favour composition over inheritance
- Uses composition to compose any number of observers with their Subject.
- Relationship is not set up through inheritance, but at runtime by composition.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Observer/observer.png "Observer Pattern"