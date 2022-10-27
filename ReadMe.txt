AndriiN
Creating Pipeline Branches. Chapter 12 ■ Understanding the ASP.NET Core Platform p.270

The Map method is used to create a section of pipeline that is used to process requests for specific URLs, creating a separate sequence
of middleware components, as shown in Listing 12-9.

When a URL is matched by the Map method, it follows the branch and no longer passes through the middleware components
on the main path through the pipeline. The same middleware can be used in different parts of the pipeline, which can be seen in
Listing 12-9, where the QueryStringMiddleWare class is used in both the main part of the pipeline and the branch.
To see the different ways that requests are handled, restart ASP.NET Core and request the http://
localhost:5000?custom=true URL, which will be handled on the main part of the pipeline and will produce the output shown
on the left of Figure 12-15. Navigate to http://localhost:5000/branch?custom=true, and the request will be forwarded to the
middleware in the branch, producing the output shown on the right in Figure 12-15.


