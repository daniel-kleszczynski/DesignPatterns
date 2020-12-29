# Repository

<b>Summary</b>

The Repository pattern is used to encapsulate data access code. Business logic treats repository like an in-memory collection of domain objects.

<b>Use cases</b>

* Make your application independent of concrete data access technology (improves testability)

* Prevent fat LINQ queries to scatter across client code (encapsulates these queries within named repository methods)

<b>How does it work</b>

* Define interface for general repository 

* Define generic repository base class: implementation for concrete data access technology

* Define inerface for concrete repository: can have additional methods

* Concrete repository:
  - specific for certain data access technology
  - implements additional methods declared in concrete repository interface
  - derives from generic base repository class

<b>Pitfalls</b>

* Repository class can contain too many methods
* Full CRUD approach is not always needed for every scenario
* Sigle repository class can violate SRP by not allowing to have separate persistent stores for read and write operations. See CQRS as alternative.

<b>Real life examples</b>

* DataSet in ADO .NET
  (DataSet allows interaction with DataTable, DataRow, DataColumn)
  (Add, Remove, Modify data)
  
* DbSet<T> in Entity Framework

Drawbacks for direct use of DbSet<T> from Entity Framework:
- code becomes dependent on Entity Framework
- repetitions of big LINQ queries accross client code
