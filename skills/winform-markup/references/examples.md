# Examples

## Table layout

`TableLocation` takes column, row, then control; its spanning overload takes column span and row span before the control.

```csharp
new TableLayoutPanel()
    .TableLayout(2, 2, autoSize: false)
    .ColumnStyles("*|100%")
    .RowStyles("*|100%")
    .TableControls(
        new TableLocation(0, 0, new Label().Text("Name")),
        new TableLocation(1, 0, new TextBox().Dock(DockStyle.Fill)),
        new TableLocation(0, 1, 2, 1, new FlowLayoutPanel().AutoSize(true)));
```

## Binding

The overloads take the source, source expression, then optional target expression.

```csharp
new TextBox().Binding(viewModel, vm => vm.Name);
new CheckBox().Binding(viewModel, vm => vm.Enabled, box => box.Checked);
```

## Events

Some event helpers receive only the typed sender; others also receive event data.

```csharp
new Button()
    .Text("Save")
    .OnClick(button => Save());

new TextBox()
    .OnKeyDown((textBox, args) => HandleKey(args.KeyCode));
```
