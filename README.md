
# nugetMultiTargetConsumer Solution

The purpose of this Solution/Repo is to complete the training from the [nugetMultiTarget solution/repo](https://github.com/DanDeveloping/nugetMultiTarget) by showing that each source version of the nuget package is loaded into the same or higher consumer projects without any errors.

| Source Version | Consumer Project Version |
| --- | --- | 
| .NET Framework 4.7 | .NET Framework 4.8.1 |
| .NETSTANDARD 2.0 | .NET 5 | 
| .NET 6 | .NET 7 | 
| .NET 8 | .NET 8 | 

You could add more version, such as .NET Framework 4.7.2, to test .NET Framework 4.7 source. But I think these versions are enough to prove that we have a successful MultiTargetFramework Project. 

## Debugging Remote Source

First, you'll need to change your startup project to the one you want to test. 

Then put a break point at this line of code so the debugger will stop at the appropriate point. 

```
var echoResponse = echoer.Echo(message);
```

1. Start your project 
1. Hit your debug point
1. "Step Into" (F11 by default in Visual Studio) the line of code
1. And... you are there! 

You can now dig further into the remote source code and even stop into the conditional compiled section to see, for certain, which version of the code is executing 

You will be able to step through the executing code and see where the debugger steps when it hits conditional compile statements. 

It is a simple case, but complexity is not the point of these projects but to see how we can generate the right projects for our consumers. 

## IMPORTANT Visual Studio Setting

When using Visual Studio DO NOT forget to turn off (uncheck) your "Just My Code" located in your menu at | Debug | Options... => Debugging | General | Enable Just My Code.  Having this enabled/checked will cause your debugger to skip loading symbols from the nuget package preventing you from stepping through that code.  Don't ask me how I know, please.

## Closing Thoughts 

I hope you learned something using these projects. 

Now get out there and make your own! 

DanDeveloping
