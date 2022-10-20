AndriiN
Defining Middleware Using a Class

Defining middleware using lambda functions is convenient, but it can lead to a long and complex Configure method in the Startup
class and makes it hard to reuse middleware in different projects. Middleware can also be defined using classes.

Middleware classes receive a RequestDelegate as a constructor parameter, which is used to forward the request to the next
component in the pipeline. The Invoke method is called by ASP.NET Core when a request is received and receives an HttpContext
object that provides access to the request and response, using the same classes that lambda function middleware receives. The
RequestDelegate returns a Task, which allows it to work asynchronously.
One important difference in class-based middleware is that the HttpContext object must be used as an argument when
invoking the RequestDelete to forward the request, like this:
...
await next(context);
...
Class-based middleware components are a