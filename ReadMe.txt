AndriiN
Configuring Middleware. Chapter 12 ■ Understanding the ASP.NET Core Platform p.274

There is a common pattern for configuring middleware that is known as the options pattern and that is used by some of the built-in
middleware components described in later chapters

The starting point is to define a class that contains the configuration options for a middleware component. Add a class file
named MessageOptions.cs to the Platform folder with the code shown in Listing 12-13. 
The MessageOptions class defines properties that detail a city and a country. In Listing 12-14, I have used the options pattern to
create a custom middleware component that relies on the MessageOptions class for its configuration. I have also removed some of
the middleware from previous examples for brevity.



