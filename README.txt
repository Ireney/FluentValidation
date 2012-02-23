FluentValidation (c) Jeremy Skinner
http://www.jeremyskinner.co.uk

A small validation library for .NET that uses a fluent interface 
and lambda expressions for building validation rules.

If you are have checked out the source using git, please note that 
this repository requires that autocrlf is set to false.

This project is licensed under the Apache License 2.0 
http://www.apache.org/licenses/LICENSE-2.0.html

For documentation, binary releases, discussions and the issue tracker please visit the CodePlex site:
http://fluentvalidation.codeplex.com


Ireney's fork includes the following changes:

- targets .NET 3.5
- implements new IValidationResult interface to ease mocks

This also excludes MVC3 and Tests projects from the solution. To be addressed at a later time.
