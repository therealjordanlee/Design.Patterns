![alt text][pattern]

- Iterator Pattern provides a way to access the elements of an aggregate object sequentiallly without exposing its underlying representation.
- Gives a way to step through the elements of an aggregate without having to know how things are represented under the hood.
- This provides a uniform way for accessing elements across different aggregate objects.
- Places the responsibility of traversing elements to the iterator object rather than the aggregate object.
- This keeps the aggregate interface simple, and keeps it focussed on managing a collection of objects rather than iteration.

# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- The implementation of collections between different aggregates. (e.g. Array vs List vs Hashmaps, etc)

## Program to an interface, not an implementation
- The IIterator interface provides the abstraction for iterating over aggregates.

## Favour composition over inheritance
- Iterators are composed of the aggregate object they iterate upon.


[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Iterator/iterator.png "Iterator Pattern"