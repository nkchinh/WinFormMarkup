---
name: winform-markup
description: Build or update Windows Forms interfaces using NKChinh.WinFormMarkup fluent extensions, including layouts, events, bindings, and hand-authored localization resources. Use when consuming this library or replacing WinForms Designer initialization with its markup syntax.
metadata:
  author: nkchinh
  version: "0.2.0"
  repository: https://github.com/nkchinh/WinFormMarkup
  source: https://github.com/nkchinh/WinFormMarkup/tree/main/skills/winform-markup
---

# WinFormMarkup

Use WinFormMarkup to express ordinary WinForms construction as nested fluent chains. The NuGet package is `NKChinh.WinFormMarkup`; the extension namespace remains `WinFormMarkup.Extensions`.

## Establish the available API

Check the consuming project's package reference and target framework before adding dependencies or choosing overloads. This fork currently targets `net8.0-windows` and `net471`; do not assume every fork API exists in the original `WinFormMarkup` package or an older version.

When working in the library repository, inspect `projects/WinFormMarkup/Extensions/` for signatures and `samples/BasicApp/MainWindow.cs` for composition. In another repository, use the installed package's XML documentation or source. Verify unfamiliar methods rather than inventing fluent equivalents for every WinForms property.

## Compose the interface

- Import `WinFormMarkup.Extensions`. Extensions generally mutate the receiver and return that same instance, preserving its concrete type.
- Construct child controls inline and attach them with `.Controls(...)`. Keep fields or locals for controls needed later; avoid a field for every child solely to reproduce Designer output.
- Use `.MainMenuStrip(...)` and `.StatusStrip(...)` on a form with `ToolStripItem` arguments. These helpers create and attach the corresponding strips. Compose menus with `.DropDownItems(...)` and shortcuts with `.Keys(...)`.
- Use `.Panel1(...)` / `.Panel2(...)` for split containers and `.Nodes(...)` for tree composition when the installed API supports them.
- Use `.Also(control => { ... })` for configuration without a suitable extension. Check that `Also` exists for the receiver type; it is not an extension on every object.
- Event helper names and callback arguments vary by receiver. Verify whether the callback receives a control, node, or event data. Existing extensions do not replace WinForms event lifetime or UI-thread rules.
- Preserve the application's startup and display lifecycle. Do not add `.Show()` simply because a sample uses it.

For tables, `.TableLayout(columns, rows, autoSize: true)` sets dimensions and `AutoSize`, which defaults to `true`; pass `autoSize: false` when the layout requires it. `.TableControls(new TableLocation(column, row, control), ...)` places children. The spanning constructor is `TableLocation(column, row, columnSpan, rowSpan, control)`. `.ColumnStyles("*|100%")` and `.RowStyles("*|100%")` append styles: `*` means AutoSize, a percentage means Percent, and a number means Absolute. Do not treat `*` as proportional star sizing or repeated calls as replacement.

For data binding, `.Binding(source, source => source.Property)` targets `Text`. The overload with a target expression supports another property and optional conversion delegates. The target expression must directly access the control's property, such as `control => control.Checked`; avoid calculations or casts because the implementation casts the expression body to `MemberExpression`. These helpers use `DataSourceUpdateMode.OnPropertyChanged` with formatting disabled; they do not provide property-change notification for the source. Preserve or implement the source's notification mechanism as needed.

## Localize hand-authored UI

Resources are authored in `.resx` files; fluent construction does not generate them. For a `MainWindow` form, provide `MainWindow.resx` and culture variants such as `MainWindow.fr.resx`, embedded under the resource name corresponding to the form's namespace and type. The same approach applies to a `UserControl` or custom control that owns its own resources.

Create one manager for the owning instance and share it with its components:

```csharp
using WinFormMarkup.Extensions;

public class MainWindow : Form
{
    public MainWindow()
    {
        this.Text("Main Window")
            .Localize(out var resources)
            .Controls(
                new Button()
                    .Text("Save")
                    .Localize(resources, "saveButton")
                    .Dock(DockStyle.Bottom));
    }
}
```

- `this.Localize(out var resources)` creates a `ComponentResourceManager` using `this.GetType()` and applies the fixed key `"$this"`. Use it on the owning Form or UserControl, or a custom control with resources for its runtime type.
- `this.Localize("customKey", out var resources)` creates the manager and applies an explicit key.
- `component.Localize(resources, "saveButton")` reuses the manager and applies resources to a `Component`, including controls and `ToolStripItem` instances. Do not create another manager for each child.
- Resource entries identify properties: `$this.Text`, `saveButton.Text`, `fileMenu.Text`. The explicit key does not depend on `Control.Name`; do not assign `Name` merely to make localization work.
- Apply fallback text before `.Localize(...)`. Calls after localization override the corresponding resource values; use that order only for deliberate overrides.
- These methods apply resources immediately. They neither traverse children nor subscribe to culture changes. To change language at runtime, explicitly reapply resources to the relevant components or recreate the view according to the application's design.
- A Designer `Localizable` flag is not required for these calls. What matters is that matching embedded resources exist for the manager's runtime type.

## Verify the result

Build the consuming project for its intended target framework. For layout or localization changes, inspect the resulting form when a runnable environment is available, checking docking order, resizing, translated text, and resource lookup. Do not migrate unrelated Designer-managed views or add an MVVM framework as part of ordinary markup usage.
