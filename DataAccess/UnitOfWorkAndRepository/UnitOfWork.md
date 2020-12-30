# Unit of work

<b>Summary</b>

Unit of work tracks changes in persistent objects and manages a process of writing these changes in a transaction manner

<b>Use cases</b>

* Manage transactions (Save all changes or nothing)

* You need to save changes to many different objects from persistent store without multiple trips to the database

* Manage concurrency problems (Rollback changes if  particular objects have been modified before in persistent store)

<b>How does it work</b>

* General interface IUnitOfWork declares Commit method

* Every concrete IConcreteUnitOfWork interface can declare its own set of repositories

* ConcreteUnitOfWork is for a certain DataAccess technology

* UnitOfWork within constructor initializes concrete Repositories and exposes them as read-only properties

* Persistent objects available within repositories are modified by a business logic and Unit of work must have a way to track these changes

* In a Commit method all changes to the repositories are written to persistent store (e.g. In Entity Framework dbContext.SaveChanges() is called)


<b>Pitfall</b>

Unit of work should have limited lifecycle in order to prevent leaving unecessary open conection to persistent store.

* while processing a request in a controller (web application)
* while the form is open (desktop application)


<b>Real life examples</b>

* SqlDataAdapter – represents Unit of work (Update method persists data like a Commit)

* DbContext – represents Unit of work (SaveChanges persists data like a Commit)

Drawback of direct use of DbContext from Entity Framework:

Client code becomes tightly coupled to Entity Framework technology


