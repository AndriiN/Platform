AndriiN
Short-Circuiting the Request Pipeline. Chapter 12 ■ Understanding the ASP.NET Core Platform p.268

Components that generate complete responses can choose not to call the next function so that the request isn’t passed on.
Components that don’t pass on requests are said to short-circuit the pipeline, which is what the new middleware component shown
in Listing 12-8 does for requests that target the /short URL.

Even though the URL has the query string parameter that is expected by the next component in the pipeline, the request
isn’t forwarded, so that middleware doesn’t get used. Notice, however, that the previous component in the pipeline has added its
message to the response. That’s because the short-circuiting only prevents components further along the pipeline from being used
and doesn’t affect earlier components, as illustrated in Figure 12-13
