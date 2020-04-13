# Prototype

<b>Summary</b>

Create a standalone clone from the existing object (concrete prototype) with a certain state.

<b>Use when</b>

* Construction of object is expensive due to external dependencies
  (e.g. use of a web connection, database access)

* Particular state of the object is important and it is hard or imposibble to manually recreate
  (e.g. The state is created based on the user actions)
  
* When desining an api and do not want to expose complex constructors for clients
  (Prepare one or more prototypes and allow them to be cloned)
  
<b>How does it work</b>

* Create an interface or abstract class with the Clone method returning a new object with a copied state (Prototype)

* Create any class that implements a Prototype (Concrete Prototype)

* In .NET IClonable interface defines a Prototype (Clone method returns an object type)

* Object MemberWiseClone method creates a shallow copy

* To provide a deep copy you need to implement IClonable recursively

<b>Real world example</b>

JavaScript objects are created as a copy from prototypes
