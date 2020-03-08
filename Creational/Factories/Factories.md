# Factories

<b>Summary - Factory method</b>

Defines an abstact method for creating different types of related objects in concrete factories.

<b>Summary - Abstract Factory</b>

Defines abstraction to create families of related objects. It can contain several factory methods to implement.

<b>Use cases</b>

* Separation of object construction from a business logic
  (Client code is testable and easily extendable)
  
* Use it to let other applications easily extend your framework 
  (Create custom versions of concrete factory and concrete product)
  
* Reuse existing objects instead of creating new ones

<b>How does it work – Factory method</b>

* Iterface defines a factory method returning an abstract product type

* Concrete factories implement this interface by returning specific products

* In client code replace direct instantiations with a use of new keyword

* Instead call a factory method to return an instance of type following the interface expected by a client

* Alternatively base factory can return a default product implementation

* Type of  used factories and returned products can be defined at runtime based on user inputs, values from database or configuration file etc.

<b>How does it work – Abstract factory</b>

* Interface defines a fixed number of methods returning abstract products

* Concrete factory implements defined factory methods
  (Returning a family of products)
  
* Client at runtime defines both concrete type of factory and creation method

<b>Abstract factory – drawback</b>

Adding additional product type to the abstract factory requires implementing new methods in all concrete factories.
