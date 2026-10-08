namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for ToolStrip.
/// </summary>
public static class ToolStripExtensions
{
    /// <summary>
    ///     Appends the supplied items to the tool strip and returns the strip.
    /// </summary>
    /// <param name="strip">The instance to configure.</param>
    /// <param name="items">The items to add.</param>
    /// <typeparam name="TToolStrip">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="strip" /> instance for fluent composition.</returns>
    public static TToolStrip Items<TToolStrip>(
        this TToolStrip strip,
        params ToolStripItem[] items)
        where TToolStrip : ToolStrip
    {
        strip.Items.AddRange(items);
        return strip;
    }
}