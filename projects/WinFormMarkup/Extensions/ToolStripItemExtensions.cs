namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for ToolStripItem.
/// </summary>
public static class ToolStripItemExtensions
{
    /// <summary>
    ///     Sets the Alignment property and returns the same instance.
    /// </summary>
    /// <param name="item">The instance to configure.</param>
    /// <param name="textAlign">The value to assign to Alignment.</param>
    /// <typeparam name="TToolStripItem">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="item" /> instance for fluent composition.</returns>
    public static TToolStripItem Alignment<TToolStripItem>(
        this TToolStripItem item,
        ToolStripItemAlignment textAlign)
        where TToolStripItem : ToolStripItem
    {
        item.Alignment = textAlign;
        return item;
    }

    /// <summary>
    ///     Invokes the configuration action immediately and returns the same instance.
    /// </summary>
    /// <param name="item">The instance to configure.</param>
    /// <param name="action">The action invoked with the current instance.</param>
    /// <typeparam name="TToolStripItem">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="item" /> instance for fluent composition.</returns>
    public static TToolStripItem Also<TToolStripItem>(
        this TToolStripItem item,
        Action<TToolStripItem> action)
        where TToolStripItem : ToolStripItem
    {
        action.Invoke(item);
        return item;
    }

    /// <summary>
    ///     Subscribes the action to the Click event and returns the same instance.
    /// </summary>
    /// <param name="item">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TToolStripItem">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="item" /> instance for fluent composition.</returns>
    public static TToolStripItem Clicked<TToolStripItem>(
        this TToolStripItem item,
        Action<TToolStripItem> action)
        where TToolStripItem : ToolStripItem
    {
        item.Click += (sender, _) => action.Invoke((sender as TToolStripItem)!);
        return item;
    }


    /// <summary>
    ///     Sets the Enabled property and returns the same instance.
    /// </summary>
    /// <param name="item">The instance to configure.</param>
    /// <param name="enabled">The value to assign to Enabled.</param>
    /// <typeparam name="TToolStripItem">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="item" /> instance for fluent composition.</returns>
    public static TToolStripItem Enabled<TToolStripItem>(
        this TToolStripItem item,
        bool enabled)
        where TToolStripItem : ToolStripItem
    {
        item.Enabled = enabled;
        return item;
    }

    /// <summary>
    ///     Sets the Text property and returns the same instance.
    /// </summary>
    /// <param name="item">The instance to configure.</param>
    /// <param name="text">The value to assign to Text.</param>
    /// <typeparam name="TToolStripItem">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="item" /> instance for fluent composition.</returns>
    public static TToolStripItem Text<TToolStripItem>(
        this TToolStripItem item,
        string text)
        where TToolStripItem : ToolStripItem?
    {
        item.Text = text;
        return item;
    }

    /// <summary>
    ///     Sets the TextAlign property and returns the same instance.
    /// </summary>
    /// <param name="item">The instance to configure.</param>
    /// <param name="textAlign">The value to assign to TextAlign.</param>
    /// <typeparam name="TToolStripItem">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="item" /> instance for fluent composition.</returns>
    public static TToolStripItem TextAlign<TToolStripItem>(
        this TToolStripItem item,
        ContentAlignment textAlign)
        where TToolStripItem : ToolStripItem
    {
        item.TextAlign = textAlign;
        return item;
    }
}