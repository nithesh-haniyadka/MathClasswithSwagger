ASP.Net 5

Dependency Injection

1. It allows us to develop loosely-coupled code.
2.The intent of Dependency Injection is to make code maintainable.
3.Dependency Injection reduces the hard-coded dependencies among your classes by injecting those dependencies at run time instead of design time technically.

There ae three types of Dependency Injection
a. Constructor Injection.
b. Property Injection.
c. Method Injection.

AddScoped()

In a scoped service, with every HTTP request, we get a new instance. However, within the same HTTP request, if the service is required in multiple places, like in the view and in the controller, then the same instance is provided for the entire scope of that HTTP request. But every new HTTP request will get a new instance of the service.

AddSingleton()
creates a single instance of the service when it is first requested and reuses that same instance in all the places where that service is needed.

AddTransient()
With a transient service, a new instance is provided every time a service instance is requested whether it is in the scope of the same HTTP request or across different HTTP requests.
