
*Why **"XTB"**? 
This started from what I needed for the XrmToolBox tools, but it has been growing into separate features, see below!*


# Rappen's Shared Projects


## Rappen.XRM.Helper

This is a C# Shared Project with various [CRMSDK](https://docs.microsoft.com/en-us/power-apps/developer/data-platform/?WT.mc_id=BA-MVP-5002475) addons, helper classes and extensions methods to work smoothly with [Microsoft Dataverse SDK](https://docs.microsoft.com/en-us/powerapps/developer/data-platform/?WT.mc_id=BA-MVP-5002475).

It is adding extensions to 
[IOrganizationService](https://docs.microsoft.com/en-us/power-apps/developer/data-platform/org-service/overview?WT.mc_id=BA-MVP-5002475)
of both [Entity (Table)](https://docs.microsoft.com/en-us/power-apps/developer/data-platform/reference/about-entity-reference?WT.mc_id=BA-MVP-5002475)
and [Attribute (Column)](https://docs.microsoft.com/en-us/power-apps/developer/data-platform/reference/entities/attribute?WT.mc_id=BA-MVP-5002475)
and all [Metadata](https://docs.microsoft.com/en-us/dotnet/api/microsoft.xrm.sdk.metadata?WT.mc_id=BA-MVP-5002475).

Also [PluginBase](https://docs.microsoft.com/en-us/power-apps/developer/data-platform/plug-ins?WT.mc_id=BA-MVP-5002475) is added too,
and a [CanaryTrace](https://jonasr.app/2017/09/canary/),
serializations etc.

## Rappen.XRM.Tokens

*The methods called `XrmSubstituter` has been renamed to `Tokens` in this new shared project, available from 2022-11-10.*

This is a C# Shared Project with one goal being to replace "XRM Tokens" text into the actual data.

It has recently added the [Power Fx formulas](https://learn.microsoft.com/en-us/power-platform/power-fx/formula-reference?WT.mc_id=BA-MVP-5002475), into, mixed with, together with, the [XRM Tokens](XRM-Tokens). Read more [in my docs to see what you can do](https://jonasr.app/xrm-tokens/#powerfx)!

With Power Fx it needs a bit more assemblies (read about which in [XRM Tokens](XRM-Tokens)) and that is why it is now in a new shared project.

## Rappen.XTB.Helper

This is a C# Shared Project with various [WinForm](https://docs.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-visual-studio?WT.mc_id=BA-MVP-5002475) UI controls, helper classes and extention methods to work smoothly with [Microsoft Dataverse SDK](https://docs.microsoft.com/en-us/powerapps/developer/data-platform/?WT.mc_id=BA-MVP-5002475).

I try to make the controls as 'just like controls' as TextBox, CheckBox, ComboBox etc, only with a few added properties, methods and events to add Dataverse features.

&nbsp;

---
&nbsp;
# How To Use It

## Submodule
How to [add the submodule](Git-Submodule).

&nbsp;

## Sample Code
Check out repo [Rappen.XTB.Helper.Tester](https://github.com/rappen/Rappen.XTB.Helper.Tester) for a complete sample project using all controls.

---
&nbsp;

# Controls
Read all about [Controls](Controls).

---
&nbsp;

# XRM Tokens
Read all links and info about [XRM Tokens](XRM-Tokens) (renamed from XrmSubstituter on 2022-11-10).

---
&nbsp;

# History

This project stems from tools and snippets collected over a number of years.
Some of the controls have been inherited/migrated from the [xrmtb.XrmToolBox.Controls](https://github.com/jamesnovak/xrmtb.XrmToolBox.Controls) project created and maintained by [@jamesnovak](https://github.com/jamesnovak/). 
This was partially in turn inherited/migrated from [CRMWinForm](https://github.com/rappen/CRMWinForm) by [@rappen](https://github.com/rappen/).
