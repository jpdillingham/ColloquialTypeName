# GetColloquialTypeName
C# method to return a colloquial or "pretty" name for a given Type.

## Why?

The ToString() method for the Type type returns a fully qualified name for all types, which might not be desireable.  Generic types contain some extra characters and the strings get pretty long.  For example, the ToString() method for type:

```c#
List<Tuple<string, int>>
```

returns:

```
System.Collections.Generic.List`1[System.Tuple`2[System.String,System.Int32]]
```

Not very easy on the eyes, especially if you are printing a stack trace or method signature.  ToColloquialString() for the same type returns:

```c#
List<Tuple<String, Int32>>
```

Much better!

## Usage
### Extension Method
```c#
List<Tuple<string, int>> list = new List<Tuple<string, int>>();
Console.WriteLine("The type of 'list' is: " + list.GetType().ToColloquialString());
```

### Static Method
```c#
List<Tuple<string, int>> list = new List<Tuple<string, int>>();
Console.WriteLine("The type of 'list' is: " + GetColloquialTypeName(list.GetType()));
```

## Notes
Requires the following using directives:

```c#
using System;
using System.Linq;
```

To implement the extension method, place the method within a static class, like so:

```c#
static class Extension
{
    public static string ToColloquialString(this Type type)
    {
      ...
    }
}
```
