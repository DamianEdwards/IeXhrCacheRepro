Demonstrates issue with Internet Explorer agressively caching XHR GET requests without explicit cache headers, while other browsers do not.

Fixed by sending a response Cache-Control header of "max-age=0".