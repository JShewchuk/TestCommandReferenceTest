# TestCommandReferenceTest
An example for stackoverflow that demonstrates the issue of running the command "dotnet.exe test" for MSTest and VS 2015 and referencing assemblies


e. A: C:\Users\jshewchuk\Support\Parser\APX.Shared.Parsing.MapForce.dll, T: APX.
Shared.Parsing.MapForce.WREGIS.Thermal.MappingMapToAPX_Core_MeterData. Error: Th
e system cannot find the path specified. (Exception from HRESULT: 0x80070003))
Inner Exception: 2
Exception Type: System.Exception
 Exception Source: APX.Shared.MeterData.Services
 Exception Message: Unable to load assembly or type. A: C:\Users\jshewchuk\Suppo
rt\Parser\APX.Shared.Parsing.MapForce.dll, T: APX.Shared.Parsing.MapForce.WREGIS
.Thermal.MappingMapToAPX_Core_MeterData. Error: The system cannot find the path
specified. (Exception from HRESULT: 0x80070003)
Inner Exception: 3
Exception Type: System.IO.DirectoryNotFoundException
 Exception Source: System.Private.CoreLib
 Exception Message: The system cannot find the path specified. (Exception from H
RESULT: 0x80070003)
2017-02-15 12:45:10.891 -05:00 [Information] [Microsoft.AspNetCore.Mvc.Internal.
ObjectResultExecutor] [{ Id: 1 }] Executing ObjectResult, writing value "Microso
ft.AspNetCore.Mvc.ControllerContext".
2017-02-15 12:45:10.892 -05:00 [Information] [Microsoft.AspNetCore.Mvc.Internal.
ControllerActionInvoker] [{ Id: 2 }] Executed action "APX.Shared.MeterData.Api.C
ontrollers.File.MeterDataController.Post (APX.Shared.MeterData.Api)" in 96.5605m
s
2017-02-15 12:45:10.893 -05:00 [Information] [Microsoft.AspNetCore.Hosting.Inter
nal.WebHost] [{ Id: 2 }] Request finished in 102.4784ms 500 application/json; ch
arset=utf-8
Passed   Live_CallbackStubs_GetUsagePointDetailsBadRequest
ConfigureServices
2017-02-15 12:45:10.988 -05:00 [Information] [Microsoft.AspNetCore.Hosting.Inter
nal.WebHost] [{ Id: 1 }] Request starting HTTP/1.1 GET http://
2017-02-15 12:45:11.028 -05:00 [Information] [Microsoft.AspNetCore.Mvc.Internal.
ControllerActionInvoker] [{ Id: 1 }] Executing action method "APX.Shared.MeterDa
ta.Api.Controllers.File.MeterDataController.Post (APX.Shared.MeterData.Api)" wit
h arguments (["APX.Shared.MeterData.Model.MeterDataFileRequest"]) - ModelState i
s Valid
2017-02-15 12:45:11.092 -05:00 [Error] [] [] Exception Type: System.Exception
 Exception Source: APX.Shared.MeterData.Api
 Exception Message: Unexpected custom exception
Inner Exception: 1
Exception Type: System.AggregateException
 Exception Source:
 Exception Message: One or more errors occurred. (Unable to load assembly or typ
e. A: C:\Users\jshewchuk\Support\Parser\APX.Shared.Parsing.MapForce.dll, T: APX.
Shared.Parsing.MapForce.WREGIS.Thermal.MappingMapToAPX_Core_MeterData. Error: Th
e system cannot find the path specified. (Exception from HRESULT: 0x80070003))
Inner Exception: 2
Exception Type: System.Exception
 Exception Source: APX.Shared.MeterData.Services
 Exception Message: Unable to load assembly or type. A: C:\Users\jshewchuk\Suppo
rt\Parser\APX.Shared.Parsing.MapForce.dll, T: APX.Shared.Parsing.MapForce.WREGIS
.Thermal.MappingMapToAPX_Core_MeterData. Error: The system cannot find the path
specified. (Exception from HRESULT: 0x80070003)
Inner Exception: 3
Exception Type: System.IO.DirectoryNotFoundException
 Exception Source: System.Private.CoreLib
 Exception Message: The system cannot find the path specified. (Exception from H
RESULT: 0x80070003)
2017-02-15 12:45:11.095 -05:00 [Information] [Microsoft.AspNetCore.Mvc.Internal.
ObjectResultExecutor] [{ Id: 1 }] Executing ObjectResult, writing value "Microso
ft.AspNetCore.Mvc.ControllerContext".
2017-02-15 12:45:11.096 -05:00 [Information] [Microsoft.AspNetCore.Mvc.Internal.
ControllerActionInvoker] [{ Id: 2 }] Executed action "APX.Shared.MeterData.Api.C
ontrollers.File.MeterDataController.Post (APX.Shared.MeterData.Api)" in 101.5476
ms
2017-02-15 12:45:11.096 -05:00 [Information] [Microsoft.AspNetCore.Hosting.Inter
nal.WebHost] [{ Id: 2 }] Request finished in 107.4975ms 500 application/json; ch
arset=utf-8
Passed   Live_CallbackStubs_PostUsagePointHeaderBadRequest
============ Test Run Summary ============
Total tests: 11. Passed: 10. Failed: 1. Skipped: 0
Test Run Failed.
SUMMARY: Total: 1 targets, Passed: 0, Failed: 1.

C:\Users\jshewchuk>"C:\Program Files\dotnet\dotnet.exe" test S:\stackOverflowGit
\TestCommandReferenceTest\test\HostConsoleAppTest
Project InterfaceAssembly (.NETStandard,Version=v1.6) will be compiled because t
he version or bitness of the CLI changed since the last build
Compiling InterfaceAssembly for .NETStandard,Version=v1.6

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.2628672
Project HostConsoleApp (.NETCoreApp,Version=v1.0) will be compiled because depen
dencies changed
Compiling HostConsoleApp for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.3462061
Project HostConsoleAppTest (.NETCoreApp,Version=v1.0) will be compiled because d
ependencies changed
Compiling HostConsoleAppTest for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.3337268


Discovering Tests ...
Executing Tests ...
Getting Configuration
Creating implementation via assembly
Value cannot be null.
Parameter name: path
Passed   Test_Run_HappyPath
Getting Configuration
Creating implementation via assembly
Failed   Test_CreateTestReference_HappyPath
Error Message:
   Test method HostConsoleAppTest.ProgramTests.Test_CreateTestReference_HappyPat
h threw exception:
System.ArgumentNullException: Value cannot be null.
Parameter name: path
Stack Trace:
    at System.IO.Path.GetFullPath(String path)
   at HostConsoleApp.Program.CreateITestReferenceInstance(String assemblyPath, S
tring className)
   at HostConsoleApp.Program.CreateTestReference()
   at HostConsoleAppTest.ProgramTests.Test_CreateTestReference_HappyPath()
============ Test Run Summary ============
Total tests: 2. Passed: 1. Failed: 1. Skipped: 0
Test Run Failed.
SUMMARY: Total: 1 targets, Passed: 0, Failed: 1.

C:\Users\jshewchuk>"C:\Program Files\dotnet\dotnet.exe" test S:\stackOverflowGit
\TestCommandReferenceTest\test\HostConsoleAppTest
Project InterfaceAssembly (.NETStandard,Version=v1.6) was previously compiled. S
kipping compilation.
Project HostConsoleApp (.NETCoreApp,Version=v1.0) was previously compiled. Skipp
ing compilation.
Project HostConsoleAppTest (.NETCoreApp,Version=v1.0) was previously compiled. S
kipping compilation.
Discovering Tests ...
Executing Tests ...
Getting Configuration
Creating implementation via assembly
Value cannot be null.
Parameter name: path
Passed   Test_Run_HappyPath
Getting Configuration
Creating implementation via assembly
Failed   Test_CreateTestReference_HappyPath
Error Message:
   Test method HostConsoleAppTest.ProgramTests.Test_CreateTestReference_HappyPat
h threw exception:
System.ArgumentNullException: Value cannot be null.
Parameter name: path
Stack Trace:
    at System.IO.Path.GetFullPath(String path)
   at HostConsoleApp.Program.CreateITestReferenceInstance(String assemblyPath, S
tring className)
   at HostConsoleApp.Program.CreateTestReference()
   at HostConsoleAppTest.ProgramTests.Test_CreateTestReference_HappyPath()
============ Test Run Summary ============
Total tests: 2. Passed: 1. Failed: 1. Skipped: 0
Test Run Failed.
SUMMARY: Total: 1 targets, Passed: 0, Failed: 1.

C:\Users\jshewchuk>"C:\Program Files\dotnet\dotnet.exe" test S:\stackOverflowGit
\TestCommandReferenceTest\test\HostConsoleAppTest
Project InterfaceAssembly (.NETStandard,Version=v1.6) will be compiled because t
he version or bitness of the CLI changed since the last build
Compiling InterfaceAssembly for .NETStandard,Version=v1.6

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.1800486
Project HostConsoleApp (.NETCoreApp,Version=v1.0) will be compiled because depen
dencies changed
Compiling HostConsoleApp for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.2586853
Project HostConsoleAppTest (.NETCoreApp,Version=v1.0) will be compiled because d
ependencies changed
Compiling HostConsoleAppTest for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.3229982


Discovering Tests ...
Executing Tests ...
Getting Configuration
Creating implementation via assembly
Unable to load assembly or type. A: C:\Users\jshewchuk\Support\ImplAssembly.dll,
 T: ImplAssembly.TestReference. Error: The system cannot find the path specified
. (Exception from HRESULT: 0x80070003)
Passed   Test_Run_HappyPath
Getting Configuration
Creating implementation via assembly
Failed   Test_CreateTestReference_HappyPath
Error Message:
   Test method HostConsoleAppTest.ProgramTests.Test_CreateTestReference_HappyPat
h threw exception:
System.Exception: Unable to load assembly or type. A: C:\Users\jshewchuk\Support
\ImplAssembly.dll, T: ImplAssembly.TestReference. Error: The system cannot find
the path specified. (Exception from HRESULT: 0x80070003) ---> System.IO.Director
yNotFoundException: The system cannot find the path specified. (Exception from H
RESULT: 0x80070003)
Stack Trace:
    at System.Runtime.Loader.AssemblyLoadContext.LoadFromPath(IntPtr ptrNativeAs
semblyLoadContext, String ilPath, String niPath, ObjectHandleOnStack retAssembly
)
   at System.Runtime.Loader.AssemblyLoadContext.LoadFromAssemblyPath(String asse
mblyPath)
   at HostConsoleApp.Program.CreateITestReferenceInstance(String assemblyPath, S
tring className)
--- End of inner exception stack trace ---
    at HostConsoleApp.Program.CreateITestReferenceInstance(String assemblyPath,
String className)
   at HostConsoleApp.Program.CreateTestReference()
   at HostConsoleAppTest.ProgramTests.Test_CreateTestReference_HappyPath()
============ Test Run Summary ============
Total tests: 2. Passed: 1. Failed: 1. Skipped: 0
Test Run Failed.
SUMMARY: Total: 1 targets, Passed: 0, Failed: 1.

C:\Users\jshewchuk>"C:\Program Files\dotnet\dotnet.exe" test S:\stackOverflowGit
\TestCommandReferenceTest\test\HostConsoleAppTest
Project InterfaceAssembly (.NETStandard,Version=v1.6) will be compiled because t
he version or bitness of the CLI changed since the last build
Compiling InterfaceAssembly for .NETStandard,Version=v1.6

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.1853848
Project HostConsoleApp (.NETCoreApp,Version=v1.0) will be compiled because depen
dencies changed
Compiling HostConsoleApp for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.3632473
Project HostConsoleAppTest (.NETCoreApp,Version=v1.0) will be compiled because d
ependencies changed
Compiling HostConsoleAppTest for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.3215687


Discovering Tests ...
Executing Tests ...
Getting Configuration
Creating implementation via assembly
Unable to load assembly or type. A: C:\Users\jshewchuk\Support\ImplAssembly.dll,
 T: ImplAssembly.TestReference. Error: The system cannot find the path specified
. (Exception from HRESULT: 0x80070003)
Passed   Test_Run_HappyPath
Getting Configuration
Creating implementation via assembly
Failed   Test_CreateTestReference_HappyPath
Error Message:
   Test method HostConsoleAppTest.ProgramTests.Test_CreateTestReference_HappyPat
h threw exception:
System.Exception: Unable to load assembly or type. A: C:\Users\jshewchuk\Support
\ImplAssembly.dll, T: ImplAssembly.TestReference. Error: The system cannot find
the path specified. (Exception from HRESULT: 0x80070003) ---> System.IO.Director
yNotFoundException: The system cannot find the path specified. (Exception from H
RESULT: 0x80070003)
Stack Trace:
    at System.Runtime.Loader.AssemblyLoadContext.LoadFromPath(IntPtr ptrNativeAs
semblyLoadContext, String ilPath, String niPath, ObjectHandleOnStack retAssembly
)
   at System.Runtime.Loader.AssemblyLoadContext.LoadFromAssemblyPath(String asse
mblyPath)
   at HostConsoleApp.Program.CreateITestReferenceInstance(String assemblyPath, S
tring className)
--- End of inner exception stack trace ---
    at HostConsoleApp.Program.CreateITestReferenceInstance(String assemblyPath,
String className)
   at HostConsoleApp.Program.CreateTestReference()
   at HostConsoleAppTest.ProgramTests.Test_CreateTestReference_HappyPath()
============ Test Run Summary ============
Total tests: 2. Passed: 1. Failed: 1. Skipped: 0
Test Run Failed.
SUMMARY: Total: 1 targets, Passed: 0, Failed: 1.

C:\Users\jshewchuk>
