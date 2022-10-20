AndriiN
Creating Custom Middleware. Chapter 12 Understanding the ASP.NET Core Platform 
Add Use method to Startup.cs file. Add await next()

The Use method registers a middleware component that is typically expressed as a lambda function that receives each request
as it passes through the pipeline. 
The HttpContext object describes the HTTP request and the HTTP response and provides additional context, including details
of the user associated with the request.
The middleware function I defined in Listing 12-4 uses the HttpRequest object to check the HTTP method and query string to
identify GET requests that have a custom parameter in the query string whose value is true.
No arguments are required when invoking the next middleware component because ASP.NET Core takes care of providing
the component with the HttpContext object and its own next function so that it can process the request. The next function is
asynchronous, which is why the await keyword is used and why the lambda function is defined with the async keyword.
