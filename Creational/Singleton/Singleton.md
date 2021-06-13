# Singleton

<b>Summary</b>

Allows to create only a single instance of a class

<b>Use when</b>

Access to a certain resource needs to be exclusive (also thread-safe) and possibly referenced from different parts of a client code e.g. Windows Manager, file system, printer or other hardware.

<b>Pitfalls</b>

* Default implementation is not thread-safe

* Violates Single Responsibility Principle (singleton manages its own lifetime)

* Introduces tight coupling between collaborating classes which make them harder to test
  (External dependencies should be stubbed or mocked using a dependency injection)
  (Singleton can carry a global state across many unit tests making them pass or fail depending on the order of execution)
  
* Harder to debug.
  (It is easier to analyze the code when there is a clearly defined input data)
  
Tight coupling and violation of SRP can be fixed by an IoC container which injects the same single instance for all calls. In this case Singleton design pattern is uneccessary and I consider it an anti-pattern. 

<b>How does it work</b>

A) Thread-unsafe

* Define only a default private constructor
  (As a result subclassing and creating new instances outside of a singleton class is impossible)

* Mark a singleton class as sealed
  (JIT optimization and explicit intent that a singleton should not be open for extensions as it may lead to creating multiple instances)

* Create a private static field storing an instance of this class

* Expose a singleton instance via a public property or a method

B) Thread-safe with lock

* Modify a previous implementation by surrounding instance creation with a lock block.
 
* Performance pitfall – on every call to the getter padlock is acquired
 
* You can limit performance issues by making a null check on an instance before entering a lock

C) Static initialization

Read-only instance of a singleton class is created lazily by a type initializer (It guarantees only one instance even with multi-threading)

D) Lazy<T>

* Fully lazy-loaded version.
  (Instance creation is not triggered by a call to another static member)
 
* Thread-safe
