## Oh, I tried to make it work

What I tried so far:

### Take original sample as is
This is the original sample, that you get if you create a new Universal Holographic project.
I simply removed the .csproj and replaced it with one targeting netcoreapp3.1.

It crashes in `CoreApplication.Run(exclusiveViewApplicationSource)` with
```
System.ArgumentException: 'The parameter is incorrect.

serverName'
```

### Make the view run explicitly
I tried replacing `CoreApplication.Run(exclusiveViewApplicationSource)` in `Main` with
```csharp
var exclusiveViewApplicationSource = new AppViewSource();
var win = CoreWindow.GetForCurrentThread();
win.Activate();
var appView = exclusiveViewApplicationSource.CreateView();
var coreView = CoreApplication.GetCurrentView();
appView.Initialize(coreView);
appView.SetWindow(win);
appView.Run();
```

That actually went all the way to start the loop, but unlike the original UWP Holographic .csproj
it did not start an 'immersive' view (the cliff house stayed, and basically nothing happened),
despite me seeing `deviceResources.Present(currentFrame)` being hit ever 16ms.