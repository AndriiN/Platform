AndriiN
Understanding the Return Pipeline Path. Chapter 12 ■ Understanding the ASP.NET Core Platform

Middleware components can modify the HTTPResponse object after the next function has been called, as shown by the new
middleware in Listing 12-7.

Middleware can operate before the request is passed on, after the request has been processed by other components, or both.
The result is that several middleware components collectively contribute to the response that is produced, each providing some
aspect of the response or providing some feature or data that is used later in the pipeline.
