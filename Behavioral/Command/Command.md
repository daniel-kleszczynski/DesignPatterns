# Command

<b>Summary</b>

Turns a request into an object that contains all the data needed to execute dedicated action. As a result a client is completely decoupled from the implementation details and external dependencies needed to execute the command.

<b>Use cases</b>

* Modify behavior at runtime by injecting different commands

* Logging details about performed actions
  (Every command object can have a reference to the created logger instance)
  
* Validation
  (Input data validation and current receiver state)
  
* Queuying and delaying operations

* Undo operation support

<b>How does it work</b>

* Define a command abstraction with at least Execute method

* Execute method should not use any parameter with more concrete type than object
  (ICommand should be universal to use it accross the whole application)

* ICommand interface can define additional methods such as CanExecute or Undo

* Receiver is an object that contains some business logic

* Receiver reference and additional parameters should be passed in a command constructor 

* Command is passed as ICommand parameter and executed by an invoker

* Executed command triggers business logic in a receiver

<b>Real world example</b>

ICommand interface in WPF.
