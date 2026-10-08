namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for FlowLayoutPanel.
/// </summary>
public static class FlowLayoutPanelExtensions
{
    /// <summary>
    ///     Sets the FlowDirection property and returns the same instance.
    /// </summary>
    /// <param name="panel">The instance to configure.</param>
    /// <param name="direction">The value to assign to FlowDirection.</param>
    /// <typeparam name="TPanel">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="panel" /> instance for fluent composition.</returns>
    public static TPanel FlowDirection<TPanel>(
        this TPanel panel,
        FlowDirection direction)
        where TPanel : FlowLayoutPanel
    {
        panel.FlowDirection = direction;
        return panel;
    }

    /// <summary>
    ///     Sets the WrapContents property and returns the same instance.
    /// </summary>
    /// <param name="panel">The instance to configure.</param>
    /// <param name="wrap">The value to assign to WrapContents.</param>
    /// <typeparam name="TPanel">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="panel" /> instance for fluent composition.</returns>
    public static TPanel WrapContents<TPanel>(
        this TPanel panel,
        bool wrap)
        where TPanel : FlowLayoutPanel
    {
        panel.WrapContents = wrap;
        return panel;
    }
}