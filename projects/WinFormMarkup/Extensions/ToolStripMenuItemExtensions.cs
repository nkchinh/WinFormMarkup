namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for ToolStripMenuItem.
/// </summary>
public static class ToolStripMenuItemExtensions
{
    /// <summary>
    ///     Sets the ShortcutKeys property and returns the same instance.
    /// </summary>
    /// <param name="menuItem">The instance to configure.</param>
    /// <param name="shortcutKeys">The value to assign to ShortcutKeys.</param>
    /// <typeparam name="TToolStripMenuItem">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="menuItem" /> instance for fluent composition.</returns>
    public static TToolStripMenuItem Keys<TToolStripMenuItem>(
        this TToolStripMenuItem menuItem,
        Keys shortcutKeys)
        where TToolStripMenuItem : ToolStripMenuItem
    {
        menuItem.ShortcutKeys = shortcutKeys;
        return menuItem;
    }
}