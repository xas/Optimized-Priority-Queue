# High Speed Priority Queue for C&#35;

## Fork

* This is a fork from the original work of [BlueRaja](https://github.com/BlueRaja).
* This version drops support from .NET Framework below 4.5.
* Library target are `netstandard1.0`, `netstandard2.0`, and `net6.0`
* Fixed namespace naming
* Fixed file naming
* Some tests were removed, in a "fix-later" mode
* nuget package still point to the original version (5.1.0)
* Version tagged 6.0.0

## Features

* Faster (for path-finding, at least) than any other C# priority queue out there!
* Easy to use
* No dependencies on third-party libraries
* Free for both personal and commercial use
* Implements `IEnumerable<T>` for LINQ support!
* Fully unit-tested
* Has a **stable priority queue** implementation _(ie. if two items are enqueued with the same priority, they'll be dequeued in the same order they were enqueued)_
* Takes advantage of the new [forced inline support](http://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.methodimploptions%28v=vs.110%29.aspx) when compiling under .Net 4.5, for even faster speeds
* Published to [NuGet](https://www.nuget.org/packages/OptimizedPriorityQueue/) - can [easily be added to any project](https://github.com/BlueRaja/High-Speed-Priority-Queue-for-C-Sharp/wiki/Getting-Started)
* Should work on .Net versions as old as .Net 4.5

## Is this software free?

**Yes!**  See the [license page](https://github.com/BlueRaja/High-Speed-Priority-Queue-for-C-Sharp/wiki/License) for more details.

## Getting Started

This project contains two priority queue implementations - one that's super-fast _(without thread-safety, safety checks, etc)_, and one that's easy/safe to use.

See the [Getting Started](https://github.com/BlueRaja/High-Speed-Priority-Queue-for-C-Sharp/wiki/Getting-Started) page, or decide what type of queue you want:

* [I want a PriorityQueue that's easy to use](https://github.com/BlueRaja/High-Speed-Priority-Queue-for-C-Sharp/wiki/Using-the-SimplePriorityQueue)
* [I want a PriorityQueue that's as _fast_ as possible](https://github.com/BlueRaja/High-Speed-Priority-Queue-for-C-Sharp/wiki/Using-the-FastPriorityQueue)
