---
name: winform-markup
description: Build or update fluent WinForms interfaces with NKChinh.WinFormMarkup, including `.Controls(...)`, layouts, events, bindings, and hand-authored localization. Use when consuming NKChinh.WinFormMarkup or replacing `InitializeComponent` and Designer.cs construction with markup syntax.
metadata:
  author: nkchinh
  version: "0.2.1"
  repository: https://github.com/nkchinh/WinFormMarkup
  source: https://github.com/nkchinh/WinFormMarkup/tree/main/skills/winform-markup
---

# WinFormMarkup

Use WinFormMarkup to express ordinary WinForms construction as nested fluent chains. The NuGet package is `NKChinh.WinFormMarkup`; the extension namespace remains `WinFormMarkup.Extensions`.

## Establish the available API

Check the consuming project's package reference, target framework, and C# language version before choosing syntax or overloads. Read `TargetFrameworks` from the library project or installed package; .NET Framework may default to an older C# version, so avoid newer syntax unless `LangVersion` permits it. `NKChinh.WinFormMarkup` adds APIs beyond the original package, and older versions may differ.

When working in the library repository, inspect `projects/WinFormMarkup/Extensions/` for signatures and `samples/BasicApp/MainWindow.cs` for composition. In another repository, use the installed package's XML documentation or source. Verify unfamiliar methods rather than inventing fluent equivalents for every WinForms property.

## Compose the interface

- Import `WinFormMarkup.Extensions`. Extensions generally mutate the receiver and return that same instance, preserving its concrete type.
- Construct child controls inline and attach them with `.Controls(...)`. Keep fields or locals only for controls referenced elsewhere.
- Set a control's properties before composing its children. Set properties that reference child controls, such as a form's `AcceptButton` and `CancelButton`, after those controls are assigned in the control tree.
- Keep view initialization in fluent chains. Prefer available property and event extensions; use an object initializer or direct assignment only when no suitable extension exists.
- When another call needs a child reference, declare the variable before the root chain and assign it at the child's construction site. Consume the reference after that assignment. Do not move child markup into separate statements or an `Also` callback merely to retain the reference.
- Child order affects WinForms z-order and docking. The current `.Controls(...)` implementation adds children in argument order and then brings every `DockStyle.Fill` child to the front; verify the installed version before relying on that behavior. Check the relative order of edge-docked controls, and avoid multiple overlapping `Fill` controls unless that overlap is intentional.
- Use `.MainMenuStrip(...)` and `.StatusStrip(...)` on a form with `ToolStripItem` arguments. These helpers create and attach the corresponding strips. Compose menus with `.DropDownItems(...)` and shortcuts with `.Keys(...)`.
- Use `.Panel1(...)` / `.Panel2(...)` for split containers and `.Nodes(...)` for tree composition when the installed API supports them.
- Use `.Also(control => { ... })` for configuration without a suitable extension. Check that `Also` exists for the receiver type; it is not an extension on every object.
- Event helper names and callback arguments vary by receiver. Verify whether the callback receives a control, node, or event data.
- Preserve the application's startup and display lifecycle. Do not add `.Show()` simply because a sample uses it.

For a container with edge-docked and fill controls, pass all children through the same `.Controls(...)` call. The helper brings the fill control to the front so it occupies the remaining area:

```csharp
new Panel().Controls(
    new Panel().Height(40).Dock(DockStyle.Top),
    new Panel().Height(32).Dock(DockStyle.Bottom),
    new Panel().Dock(DockStyle.Fill));
```

For tables, `.TableLayout(columns, rows, autoSize: true)` sets dimensions and `AutoSize`, which defaults to `true`; pass `autoSize: false` when the layout requires it. `.TableControls(new TableLocation(column, row, control), ...)` places children. The spanning constructor is `TableLocation(column, row, columnSpan, rowSpan, control)`. `.ColumnStyles("*|100%")` and `.RowStyles("*|100%")` append styles: `*` means AutoSize, a percentage means Percent, and a number means Absolute. Do not treat `*` as proportional star sizing or repeated calls as replacement.

For example, declare button references before the form chain, construct them inside the layout, then set the form's dialog properties after `.Controls(...)`:

```csharp
Button save;
Button cancel;

this.Text("Database connection")
    .StartPosition(FormStartPosition.CenterParent)
    .Localize(out var resources)
    .Controls(new FlowLayoutPanel()
        .AutoSize(true)
        .FlowDirection(FlowDirection.RightToLeft)
        .Controls(
            cancel = new Button()
                .AutoSize(true)
                .Also(button => button.DialogResult = DialogResult.Cancel)
                .Text("Cancel")
                .Localize(resources, "cancelButton"),
            save = new Button()
                .AutoSize(true)
                .Also(button => button.DialogResult = DialogResult.OK)
                .Text("Save")
                .Localize(resources, "saveButton")))
    .AcceptButton(save)
    .CancelButton(cancel);
```

For data binding, `.Binding(viewModel, vm => vm.Property)` targets `Text`; the target-expression overload supports another property and optional converters. Do not shadow local names in lambda parameters because C# 7.3 rejects it. The target expression must be a direct member access such as `box => box.Checked` because the implementation casts its body to `MemberExpression`. Bindings use `DataSourceUpdateMode.OnPropertyChanged` without formatting and do not add source notifications.

Event helpers use the `On...` prefix; verify their callback signature. `.Controls(...)` and `.TableControls(...)` suspend and resume only while adding their children. Use normal WinForms layout, ownership, disposal, event-lifetime, and UI-thread rules elsewhere.

When implementing tables, bindings, or event handlers, read [examples](references/examples.md) for verified call shapes.

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

Build for the intended target framework. When Windows UI is available, inspect docking, resizing, localization, and resource lookup. Otherwise, try a compile-only build with `EnableWindowsTargeting=true`, review resource names and control order statically, and report that the UI was not run. Do not migrate unrelated Designer views or add MVVM as part of ordinary markup usage.
