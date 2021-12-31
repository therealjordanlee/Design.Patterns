![alt text][pattern]

- Composite Pattern allows us to build structures of objects in the form of trees that contain both compositions of objects and individual objects as nodes.
- With a composite structure, we can apply the same operations over both composites and individual objects.
- I.e. We can ignore the differences between compositions of objects and individual objects.

- A Composite contains Components.
- Components come in 2 forms: composites and leaf elements.
- A composite holds a set of children.
- Children may be other composites or leaf elements.
- Organizing data in this way results in an upside-down tree structure, with a composite at the root, and branches of composites growing up into leaves.

# Intent
- Simplifies life for clients. Collections and individual objects both have aa uniform interface, so there is no longer a need to implement conditionals for each scenario.

# Design Principles
## Identify the aspects of your application that vary and separate them from what stays the same
- Composition of objects (composites) vs individual objects.

## Program to an interface, not an implementation
- The abstract Component class provides the interface for access items in the composite structure.

## Favour composition over inheritance
- Individual leaf nodes components are composed of the data/data structure.
- Composite components are composed of leaf nodes and other composite components.

[pattern]: https://github.com/therealjordanlee/Design.Patterns/raw/master/src/Composite/composite.png "Composite Pattern"