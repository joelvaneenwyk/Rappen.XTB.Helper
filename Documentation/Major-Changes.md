## 2022-11-10 - Separated XrmSubstituter to XRMTokens

The old Substituter was in only one file (even also using other features in `Rappen.XRM.Helpers` too) has now been moved to a new shared project `Rappen.XRM.Tokens`, with it's own namespace etc.

The new project has been separated since it now supports [Microsoft Power Fx formulas](https://learn.microsoft.com/en-us/power-platform/power-fx/formula-reference?WT.mc_id=BA-MVP-5002475) which needs a few more assemblys. This is why not uncluded in existing projects, including the Power Fx is a bit harder.

---

## 2022-04-19 - Separated even better

The folder path to the both projects are changes, so shared projects have to be removed and readded.

A lot of namespaces in the `Rappen.XRM.Helpers` shared project ha been changed from `Rappen.XTB.Helpers*` to `Rappen.XRM.Helpers*`.

---

## 2021-09-26 - Separate into two projects

Previously everything was in one shared project: `Rappen.XTB.Helpers`.

This is now changed to two share projects:
<br/>&nbsp;  `Rappen.XRM.Helpers.shproj`<br/>&nbsp;  `Rappen.XTB.Helper.shproj`

If you use these helpers, but only for the CRMSDK features, only the `Rappen.XRM.Helper.shproj` is needed.
If you use it for instance for plugins, the second cannot be included, as `Rappen.XTB.Helper.shproj` requires by `System.Windows.Forms`.

When you create XrmToolBox tools or similar, both share projects are added.
