# Strategy

<b>Summary</b>

Defines a family of algorithms which are encapsulated in separated classes and used interchangeably by a client via a common interface.

<b>Use when</b>

* Avoid potentially growing conditional operator e.g. switch or if statement
  (violation of Open-Closed principle)
  
* Isolates a genaral business logic from implementation details of concrete algorithms
  (Single responsibility principle)
  
* Reduce a duplicate code in a related classes by extracting common logic to the class using those classes 
  (Related classes contain only what differs)
  
* Switch between different implementations at runtime
  (Supports also mocking for unit testing)
  
<b>Drawback</b>

 Strategy cannot refer to members of the containing class
 
 <b>How does it work</b>
 
 * Abstract strategy defines a method representing some work to be done
 
 * Concrete classes provide various implementations
 
 * Client receives injected object and interects with it using a strategy abstraction
 
 * Concrete strategy object can be switched at runtime providing different implementation
 
 <b>Real life examples</b>
 
 * Delegates
 
 * Service injection in ASP.NET
  
  
