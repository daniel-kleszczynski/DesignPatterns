<b>Summary:</b>

Allows objects with incompatible interfaces to collaborate.

<b>Use cases:</b>

* Calling a service force complex operations across the client code
e.g. data conversions
(perform these operations only in the adapter)

* Service interface is not constant:
a) Need to quickly switch the third-party libraries without breaking the client code
b)  Third-party code can change independently

* You need to use several existing services, but it is impractical to adapt their interface by subclassing every one of them in the client code.
(Adapter can contain more than one service class and expose proper interface for a client)

<b>How does it work</b>

* Adapter implements the interface used by the client

* The interface used by the client is constant

* Client calls the Adapter method

* Adapter perform some adaptation i.e. operations needed to use the service

* Adapter calls the suitable method/methods of adaptee passing data with correct format

* Adapter can work in two directions
