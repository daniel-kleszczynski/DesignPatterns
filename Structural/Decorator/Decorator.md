# Decorator

<b>Summary:</b>

Attaches a new behavior to object by placing this object inside special wrapper that contains additional behavior.

<b>Use cases:</b>

* Add a new functionality to the legacy system without messing with a spaghetti code e.g. input data validation

* Extend a sealed class (cannot create a subclass)

* Prevent a class explosion (should not create a subclass for every combination of traits)*

* Add or remove behaviors from object at runtime

* Combine several behaviors with custom combination order

<b>How does it work</b>

* Concrete component is an implementation of an abstract component

* Abstract decorator derives from an abstract component

* Concrete decorator is an implementation of  an abstract decorator

* Decorator holds a reference to the object of type abstract component

* Neither client nor concrete component is aware that business object is wrapped inside a stack of decorators altering its behavior

<b>Drawback:</b>

All methods in a decorated interface must be implemented in a decorator class. 

Some of them do not add any additional behavior, but still must be implemented as forwarding methods to keep existing behavior. 

