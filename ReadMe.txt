AndriiN
Using the Options Pattern with Class-Based Middleware. Chapter 12 ■ Understanding the ASP.NET Core Platform p.277

Although the options pattern can be used with lambda function middleware, you will usually see it applied to class-based
middleware, such as the built-in features described in Chapters 15 and 16. When used with class-based middleware, the
configuration options don’t have to be accessed through a Startup.Configure method parameter, which produces a more elegant
result.
Add the statements shown in Listing 12-15 to the Middleware.cs file to define a class-based middleware component that uses
the MessageOptions class for configuration.
The LocationMiddleware class defines an IOptions<MessageOptions> constructor parameter. In Listing 12-16, I have replaced
the lambda function middleware component with the class from Listing 12-15 and removed the IOptions<MessageOptions>
parameter.
When the UseMiddleware statement is executed, the LocationMiddleware constructor is inspected, and its
IOptions<MessageOptions> parameter will be resolved using the object created in the ConfigureServices method. This is done
using the dependency injection feature that is described in Chapter 14, but the immediate effect is that the options pattern can be
used to easily configure class-based middleware. Restart ASP.NET Core and request http://localhost:5000/location to test the
new middleware, which will produce the same output as shown in Figure 12-17.



