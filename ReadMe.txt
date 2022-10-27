AndriiN
Creating Terminal Middleware. Chapter 12 ■ Understanding the ASP.NET Core Platform p.272

Terminal middleware never forwards requests to other components and always marks the end of the request pipeline

The component will forward requests only when the constructor has been provided with a non-null value for the nextDelegate
parameter. Listing 12-12 shows the application of the component in both standard and terminal forms.
There is no equivalent to the UseMiddleware method for terminal middleware, so the Run method must be used by creating
a new instance of the middleware class and selecting its Invoke method. Using the Run method doesn’t alter the output from the
middleware, which you can see by restarting ASP.NET Core and navigating to the http://localhost:5000/branch?custom=true
URL, which produces the content shown in Figure 12-16.



