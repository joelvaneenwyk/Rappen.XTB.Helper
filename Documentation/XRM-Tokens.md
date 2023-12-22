*Renamed from `XrmSubstitutes` to `XRM Tokens` on the 2022-11-10.*

This is an extension to the [`Entity`🔗](https://docs.microsoft.com/en-us/dotnet/api/microsoft.xrm.sdk.entity?WT.mc_id=BA-MVP-5002475) class used to replace [**XRM Tokens**](https://jonasr.app/xrm-tokens) in a text with dynamic data from a Dataverse record, also may be mixed with [**Power Fx**](https://learn.microsoft.com/en-us/power-platform/power-fx/formula-reference?WT.mc_id=BA-MVP-5002475).

&nbsp;

# The Method

Signature:
```csharp
public static string Tokens(this Entity entity, IOrganizationService service, string text)
```

Example:
```csharp
var theText = myEntity.Tokens(service, 
   "Name is {name} from {address1_city} born in <PowerFx|Year(DateValue("{birthdate}"))>, owned by {ownerid.firstname} with id {ownerid|<value>}.");
```

Result:
```
Name is Rapp Solutions AB from Täby born in 1971, owned by Jonas with id b0178a3c-553e-ec11-8c63-000d3a4a08d0.
```

&nbsp;

# How to install it

Use the repo as submodules, [read here](Git-Submodules).

Note: this shared project `Rappen.XRM.Tokens` requires shared project `Rappen.XRB.Helpers`.

These NuGet packages are needed in the projects that are using these shared projects, currently (*2023-11-12*) with these versions:


|Package|Version|NuGet|
|--|--|--|
| Microsoft.PowerFx.Core.dll | 1.1.0.0 | [1.1.0 🔗](https://www.nuget.org/packages/Microsoft.PowerFx.Core/1.1.0)
| Microsoft.PowerFx.Interpreter.dll |          1.1.0.0 | [1.1.0 🔗](https://www.nuget.org/packages/Microsoft.PowerFx.Interpreter/1.1.0)
| Microsoft.PowerFx.Transport.Attributes.dll | 1.1.0.0 | [1.1.0 🔗](https://www.nuget.org/packages/Microsoft.PowerFx.Transport.Attributes/1.1.0)
| System.Runtime.CompilerServices.Unsafe.dll | 4.6.28619.1 | [4.5.3 🔗](https://www.nuget.org/packages/System.Runtime.CompilerServices.Unsafe/4.5.3)
| System.Collections.Immutable.dll           | 6.0.21.52210 | [6.0.0 🔗](https://www.nuget.org/packages/System.Collections.Immutable/6.0.0)

## Use it in XrmToolBox

XrmToolBox does not include **Power Fx** assemblies (*not yet at least, currently at version 1.2022.11.59*) so the versions of assemblies below should be added to a subfolder in the Plugins folder, with the name of your tool's assembly name (minus `.dll`):

 * Microsoft.PowerFx.Core.dll
 * Microsoft.PowerFx.Interpreter.dll
 * Microsoft.PowerFx.Transport.Attributes.dll
 * en-US\Microsoft.PowerFx.Core.resources.dll
 * System.Collections.Immutable.dll

 Could be added to the NuGet Specification file:
 ```xml
<files>
   <file src="MyTool\bin\Release\My.Tool.dll" target="lib\net472\Plugins" />
   <file src="MyTool\bin\Release\Microsoft.PowerFx.*.dll" target="lib\net472\Plugins\My.Tool" />
   <file src="MyTool\bin\Release\en-US\*.dll" target="lib\net472\Plugins\My.Tool\en-US" />
   <file src="MyTool\bin\Release\System.Collections.Immutable.dll" target="lib\net472\Plugins\My.Tool" />
</files>
```

One file has to be merged with the tool assembly, as the XrmToolBox uses another version:
 * System.Runtime.CompilerServices.Unsafe.dll

&nbsp;


# Docs

See all documents at https://jonasr.app/xrm-tokens/