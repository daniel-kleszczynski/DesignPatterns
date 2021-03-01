# Builder

<b>Summary</b>

Constructs objects which require extensive configuration. It allows to create different versions of initial state by altering construction steps used in main construction flow.

<b>Use cases</b>

* Configure complex object construction via multiple method calls or properties
* Create several builders with different predefined configurations used in constant construction flow

Builder design pattern allows to avoid:
* use of huge constructor
* many specialized small constructors
* unecessary use of many subclasses (class explosion)

<b>How does it work</b>

* Abstract builder defines construction steps that all concrete builders must implement

* Concrete builders implement construction steps in a different manner
* Concrete builder defines a method or a property to return created product after construction
* Concrete builders may return products that do not follow the same interface
* Concrete builder exposes set of methods or properties for all traits of a product to be configured
* Concrete Builder may need to be restarted in order to be ready for another construction
* Director defines general construction process by calling builder methods in particular order
* Director can contain common construction code
* Director does not have the access to constructed product

1. Client configures builder via its methods or properties
2. Client passes Concrete builder to Director
3. Client calls Construct method of a Director
4. When construction is finished client gets the product from builder

<b>Real life example (uncomplete builder pattern missing director part)</b>

StringBuilder - allows to build a string via multiple method calls, result string is actually build at the end to prevent new string object creation after each concatenation (no director part)


