namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for ToolStripDropDownItem.
/// </summary>
public static class ToolStripDropDownItemExtensions
{
    /// <summary>
    ///     Appends the supplied drop-down items and returns the item.
    /// </summary>
    /// <param name="stripItem">The instance to configure.</param>
    /// <param name="items">The items to add.</param>
    /// <typeparam name="TToolStripDropDownItem">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="stripItem" /> instance for fluent composition.</returns>
    public static TToolStripDropDownItem DropDownItems<TToolStripDropDownItem>(
        this TToolStripDropDownItem stripItem,
        params ToolStripItem[] items)
        where TToolStripDropDownItem : ToolStripDropDownItem
    {
        stripItem.DropDownItems.AddRange(items);
        return stripItem;
    }
}