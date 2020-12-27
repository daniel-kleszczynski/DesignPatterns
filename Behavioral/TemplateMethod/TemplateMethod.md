# Template method

<b>Summary</b>

Defines the structure of a complex algorithm in a superclass while allowing subclasses to provide their own implementations for a certain steps.

<b>Use when</b>

* You want to allow clients to alter only centrain steps in the algorithm without completely overriding it

* You have two or more classes implementing algorithms that can share a common workflow.
  (General structure and other common parts are moved to superclass – prevented code duplication)
  
<b>Pitfalls</b>

* Structure of the algorithm must be invariant

* All implementations of the algorithm must be related through inheritance

<b>How does it work</b>

* Superclass can define abstract or virtual methods (aka hooks or steps)

* Superclass contains algorithm structure with calls to the hook methods

* Two child algorithms can be combined into one using a decorator design pattern
  (Template method interacts with both of them through a wrapper)
  
 <b>Real life example</b>
 
 ASP.NET Web Forms – Page life cycle
(In custom page you can override virtual methods such as OnInit, OnLoad etc.)
