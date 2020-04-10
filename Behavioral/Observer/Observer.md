# Observer

<b>Summary</b>

Defines a subscription mechanism to notify multiple listeners about events that happen to the object  they are observing.  

<b>Use when</b>

* One object is dependent on the changes in another object and we want to avoid polling i.e. continuously checking for updates

* When object needs to notify multiple other objects about the changes

* Observers need to subscribe or unsubscribe at runtime

* Observers need to be unaware of each other

<b>Pitfalls</b>

* Subject or observer can hold a reference to one another preventing garbage collection

* Unexpected cascade of updates when observers are allowed to modify the state of a subject

* Cannot update GUI directly from a different thread
  (WPF)
  
* Multi-threaded synchronization issues when dealing with external Observable such as  a FileWatcher
  
<b>How does it work - Traditional</b>

* Abstract Subject defines an interface to register, unregister and notify observers

* Abstract Observer defines an update method which is called when the event occurs on the subject

* Concrete subject sends notification to the list of observers

* Concrete observer contains some business logic to execute when notified

* Concrete observer contains a reference to the subject and a handler method which is triggered by the subject

<b>How does it work - Events & delegates</b>

* Subject defines one or more event delegates which are triggered when the state changes

* Observer can subscribe by adding its callback method to the delegate invocation list

* Observer can monitor multiple properties on a subject

* Observer can subscribe to multiple subjects

* Default EventArgs class can be extended which allows to pass a complex data structure to the callback method

<b>How does it work - Generic IObservable and IObserver</b>

* Solves a provider (IObservable\<T\>) ==> receiver (IObserver\<T\>) problem

* Provider defines a Subscribe method with a receiver parameter

* Subscribe method returns IDisposable object implementing Dispose method which is triggered when the object is out of the using scope

* Provider defines OnNext, OnError, OnCompleted methods

* Provider calls OnNext method to supply a receiver with a new data

* Provider calls OnError method when a next data package is unavailable or corrupted

* Provider calls OnCompleted method to indicate the end of production 

<b>Real life example</b>

* GUI Controls (Windows Forms)

* Data Bindings (WPF)

* WebClient

* FileWatcher
