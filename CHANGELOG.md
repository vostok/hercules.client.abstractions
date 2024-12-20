## 0.1.12 (12-12-2024): 

Bump NuGet deps versions

## 0.1.11 (17-10-2024):

Minor optimizations: reduce allocations count for some methods.

Move method `IHerculesTagsBuilder AddVectorOfContainers<TValue>(this IHerculesTagsBuilder builder, string key, IReadOnlyList<TValue> values, Action<IHerculesTagsBuilder, TValue> valueBuilder)` from extension into the interface `IHerculesTagBuilder`. 

## 0.1.10 (31-09-2022):

Added `IBinaryEventsReader` interface for events reading.

## 0.1.9 (06-12-2021):

Added `net6.0` target.

## 0.1.7 (23-06-2020):

Slight performance optimization (`TryAddObject` extension for `IHerculesTagsBuilder`).

## 0.1.6 (03-06-2020)

Added `HerculesEventBuilderOfT` class.

## 0.1.5 (21-05-2020)

Added `ReadStreamQuery.FetchTimeout` parameter.

## 0.1.4 (04-09-2019)

Added generic `IHerculesTimelineClient<T>`.

## 0.1.3 (24.08.2019)

`HerculesSinkProvider.Configure()` is now thread-safe.

## 0.1.2 (25.06.2019):

Added generic `IHerculesStreamClient<T>`.

## 0.1.1 (18.05.2019):

* `HerculesEventBuilder` can now be initialized from a preexisting `HerculesEvent` instance.
* `StreamCoordinates` and `TimelineCoordinates` now implement Equals() and GetHashCode().

## 0.1.0 (22-03-2019): 

Initial prerelease.
