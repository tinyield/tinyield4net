# tinyield4net
![Nuget](https://img.shields.io/nuget/v/com.tinyield.tinyield4net)

A _Minimalistic_, _extensible_ and _lazy_ sequence implementation for .Net .

## Usage

An auxiliary `Collapse()` method, which merges series of adjacent elements is written with Tinyield in the following way:

```c#
Traverser<T> Collapse<T>(Query<T> src)  {
    return yld => {
        T prev = default(T);
        src.ForEach(item => {
            if (prev.Equals(default(T)) || !prev.Equals(item))
            {
                prev = item;
                yld(item);
            }
        });
    };
}
```

This method can be chained in a sequence like this:

```c#
int[] arrange = new int[] { 7, 7, 8, 9, 9, 11, 11, 7 };
List<int> actual = Query.Of(arrange)
    .Then(n => Collapse(n))
    .Where(n => n % 2 != 0)
    .ToList();
```


## Installation

```shell
$ dotnet add package com.tinyield.tinyield4net --version 1.0.0
```

Or check the [nuget package](https://www.nuget.org/packages/com.tinyield.tinyield4net/) for more info.

## License

This project is licensed under [Apache License,
version 2.0](https://www.apache.org/licenses/LICENSE-2.0)