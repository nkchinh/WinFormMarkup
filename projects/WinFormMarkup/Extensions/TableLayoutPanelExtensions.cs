namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for TableLayoutPanel.
/// </summary>
public static class TableLayoutPanelExtensions
{
    /// <summary>
    ///     Appends column styles parsed from a pipe-delimited string and returns the panel.
    /// </summary>
    /// <remarks>
    ///     **NOTE:** columnStyles is a string delimited by '|' with values for each ColumnStyle. Values are '*' for AutoSize,
    ///     'nn.n%' for percent width, and 'nn.n' for absolute. width
    /// </remarks>
    /// <example>
    ///     var panel = new TableLayoutPanel();
    ///     panel.ColumnStyles("25|40%|40%|*");
    /// </example>
    /// <param name="tableLayoutPanel">The instance to configure.</param>
    /// <param name="columnStyles">Pipe-delimited styles: * for AutoSize, a percentage for Percent, or a number for Absolute.</param>
    /// <typeparam name="TTableLayoutPanel">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="tableLayoutPanel" /> instance for fluent composition.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static TTableLayoutPanel ColumnStyles<TTableLayoutPanel>(
        this TTableLayoutPanel tableLayoutPanel,
        string columnStyles)
        where TTableLayoutPanel : TableLayoutPanel
    {
        if (columnStyles == null) throw new ArgumentNullException(nameof(columnStyles));
        foreach (var style in columnStyles.Split('|'))
            tableLayoutPanel.ColumnStyles.Add(
                style[style.Length - 1] == '*'
                    ? new ColumnStyle { SizeType = SizeType.AutoSize, Width = 1 }
                    : style[style.Length - 1] == '%'
                        ? new ColumnStyle { SizeType = SizeType.Percent, Width = float.Parse(style.Substring(0, style.Length - 1)) }
                        : new ColumnStyle { SizeType = SizeType.Absolute, Width = float.Parse(style) });

        return tableLayoutPanel;
    }

    /// <summary>
    ///     Appends row styles parsed from a pipe-delimited string and returns the panel.
    /// </summary>
    /// <param name="tableLayoutPanel">The instance to configure.</param>
    /// <param name="rowStyles">Pipe-delimited styles: * for AutoSize, a percentage for Percent, or a number for Absolute.</param>
    /// <typeparam name="TTableLayoutPanel">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="tableLayoutPanel" /> instance for fluent composition.</returns>
    public static TTableLayoutPanel RowStyles<TTableLayoutPanel>(
        this TTableLayoutPanel tableLayoutPanel,
        string rowStyles)
        where TTableLayoutPanel : TableLayoutPanel
    {
        if (rowStyles == null) throw new ArgumentNullException(nameof(rowStyles));
        foreach (var style in rowStyles.Split('|'))
            tableLayoutPanel.RowStyles.Add(
                style[style.Length - 1] == '*'
                    ? new RowStyle { SizeType = SizeType.AutoSize, Height = 1 }
                    : style[style.Length - 1] == '%'
                        ? new RowStyle { SizeType = SizeType.Percent, Height = float.Parse(style.Substring(0, style.Length - 1)) }
                        : new RowStyle { SizeType = SizeType.Absolute, Height = float.Parse(style) });

        return tableLayoutPanel;
    }

    /// <summary>
    ///     Adds controls at the supplied table locations, applies their spans, and returns the panel.
    /// </summary>
    /// <param name="tableLayoutPanel">The instance to configure.</param>
    /// <param name="children">The children to add.</param>
    /// <typeparam name="TTableLayoutPanel">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="tableLayoutPanel" /> instance for fluent composition.</returns>
    public static TTableLayoutPanel TableControls<TTableLayoutPanel>(
        this TTableLayoutPanel tableLayoutPanel,
        params TableLocation[] children)
        where TTableLayoutPanel : TableLayoutPanel
    {
        tableLayoutPanel.SuspendLayout();
        foreach (var c in children)
        {
            tableLayoutPanel.Controls.Add(c.Control, c.Column, c.Row);
            if (c.HasSpans)
            {
                if (c.ColumnSpan > 1) tableLayoutPanel.SetColumnSpan(c.Control, c.ColumnSpan);
                if (c.RowSpan > 1) tableLayoutPanel.SetRowSpan(c.Control, c.RowSpan);
            }
        }

        tableLayoutPanel.ResumeLayout();

        return tableLayoutPanel;
    }

    /// <summary>
    ///     Sets the column count, row count, and automatic sizing behavior, and returns the panel.
    /// </summary>
    /// <param name="tableLayoutPanel">The instance to configure.</param>
    /// <param name="columnCount">The number of columns.</param>
    /// <param name="rowCount">The number of rows.</param>
    /// <param name="autoSize">Whether automatic sizing is enabled.</param>
    /// <typeparam name="TTableLayoutPanel">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="tableLayoutPanel" /> instance for fluent composition.</returns>
    public static TTableLayoutPanel TableLayout<TTableLayoutPanel>(
        this TTableLayoutPanel tableLayoutPanel,
        int columnCount,
        int rowCount,
        bool autoSize = true)
        where TTableLayoutPanel : TableLayoutPanel
    {
        tableLayoutPanel.ColumnCount = columnCount;
        tableLayoutPanel.RowCount = rowCount;
        tableLayoutPanel.AutoSize = autoSize;
        return tableLayoutPanel;
    }
}

/// <summary>Describes a control's cell and spans in a table layout panel.</summary>
public class TableLocation
{
    /// <summary>Initializes a location occupying one cell.</summary>
    /// <param name="column">The zero-based column index.</param>
    /// <param name="row">The zero-based row index.</param>
    /// <param name="control">The control to place in the cell.</param>
    public TableLocation(int column, int row, Control control) : this(column, row, 1, 1, control)
    {
        HasSpans = false;
    }

    /// <summary>Initializes a location with explicit column and row spans.</summary>
    /// <param name="column">The zero-based column index.</param>
    /// <param name="row">The zero-based row index.</param>
    /// <param name="columnSpan">The number of columns to span. Values greater than one are applied by TableControls.</param>
    /// <param name="rowSpan">The number of rows to span. Values greater than one are applied by TableControls.</param>
    /// <param name="control">The control to place in the cell.</param>
    public TableLocation(int column, int row, int columnSpan, int rowSpan, Control control)
    {
        Column = column;
        Row = row;
        ColumnSpan = columnSpan;
        RowSpan = rowSpan;
        Control = control;
        HasSpans = RowSpan > 1 || ColumnSpan > 1;
    }

    /// <summary>Gets the zero-based column index.</summary>
    public int Column { get; }
    /// <summary>Gets the zero-based row index.</summary>
    public int Row { get; }
    /// <summary>Gets the requested column span.</summary>
    public int ColumnSpan { get; }
    /// <summary>Gets the requested row span.</summary>
    public int RowSpan { get; }
    /// <summary>Gets the control to place in the table.</summary>
    public Control Control { get; }
    /// <summary>Gets whether either span is greater than one.</summary>
    public bool HasSpans { get; }
}
