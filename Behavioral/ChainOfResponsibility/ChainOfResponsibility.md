# Chain of responsibility

<b>Summary</b>

Defines a chain of handlers in a particular order. Every handler can process or pass a request to the next link in a chain.

<b>Use when</b>

* Sender needs to be decoupled from receivers

* Incoming request must be processed in a particular order by a set of handlers

* Chain of handlers can change at runtime

<b>Real life example</b>

ASP .NET Core request processing pipeline

<b>Pitfall</b>

Diffucult to debug.  In worst case a whole chain constructed at runtime must be traversed.

<b>How does it work</b>

* Sender has a reference to the first receiver

* Each receiver is only aware of the next receiver

* Receiver can process a request or pass it to the next handler

* In default implementation the first receiver to handle the message terminates the chain

* Optional response is sent back in a reverse order to the sender

* Sender is not aware which receiver handled the request
