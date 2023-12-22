## Adding to your project

1. Open a terminal at the root of a local repo and type:<br/>`git submodule add https://github.com/rappen/Rappen.XTB.Helper`
1. Right click your solution in Visual Studio, select Add Existing Project (twice), and include the projects from the cloned submodule:<br/>&nbsp;  `Rappen.XRM.Helpers.shproj` (requires for the belows)<br/>&nbsp;  `Rappen.XRM.Tokens.shproj` (if using [XRM Tokens](XRM-Tokens) and/or [Power Fx](https://jonasr.app/xrm-tokens/#powerfx))<br/>&nbsp;  `Rappen.XTB.Helper.shproj` (if creating [XrmToolBox tools](https://www.xrmtoolbox.com/documentation/#a8e2a817-d2b8-e711-813e-e0071b6502a1))
1. In your project, add a References to the both added shared project `Rappen.XRM.Helpers` and might add `Rappen.XRM.Tokens` and maybe `Rappen.XTB.Helpers`.
1. Compile the project once, to make sure everything works and to make it possible for Visual Studio to find the controls in the tool window.
1. If you added `Rappen.XTB.Helpers`, open a WinForm designer and the Tool window, and all the controls listed below should be available under a group with the name of your project.
1. Helper and extension classes can now be used and examined within the added project.

Sometimes, the submodules are not of right version of no files local, try this from the `Rappen.XTB.Helpers` folder:<br/>`git submodule update --force`

&nbsp;
## Updating your project with latest
1. Open a terminal at the root of the helper submodule. This is probably<br/>`[your project folder]\Rappen.XTB.Helpers`.
2. Type:<br/>`git pull`<br/>or<br/>`git pull https://github.com/rappen/Rappen.XTB.Helper main`

Yes, there may be slightly breaking changes, but that's life on the cutting edge.

Majorly breaking changes will be announced in [**this readme**](Major-Changes).

&nbsp;
## Remove
If you ever want to remove the submodule - read [this gits](https://gist.github.com/myusuf3/7f645819ded92bda6677) or this on [StackOverflow](https://stackoverflow.com/questions/1260748/how-do-i-remove-a-submodule/36593218#36593218).