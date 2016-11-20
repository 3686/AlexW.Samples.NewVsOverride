Demo: New vs Override in C# dotnet core
=======================================

A quick snippet to prove the `override` vs `new` inheritance in C#.

Building this sample
--------------------

Grab the Program.cs content and put it into LinqPad or build and run the dotnet core project.

To build and run this dotnetcore project in Powershell:

```
  dotnet restore;
  dotnet build;
  dotnet run;
```

Outputs
-------

```
  --- using inferred at runtime types ---
  --- BaseClass ---
  BaseClass message
  --- UsingNewSubclass ---
  BaseClass message
  UsingNewSubclass message
  --- UsingOverrideSubclass ---
  BaseClass message
  UsingOverrideSubclass message

  --- testing using base types ---
  --- BaseClass ---
  BaseClass message
  --- UsingNewSubclass used as a BaseClass type ---
  BaseClass message
  --- UsingOverrideSubclass used as a BaseClass type ---
  BaseClass message
  UsingOverrideSubclass message
```

References
----------
[Knowing When to Use Override and New Keywords (C# Programming Guides)](https://msdn.microsoft.com/en-us/library/ms173153(v=vs.80).aspx)