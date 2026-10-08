namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for ScrollableControl.
/// </summary>
public static class ScrollableControlExtensions
{
    /// <summary>
    ///     Sets the AutoScroll property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="autoScroll">The value to assign to AutoScroll.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl AutoScroll<TControl>(
        this TControl control,
        bool autoScroll)
        where TControl : ScrollableControl
    {
        control.AutoScroll = autoScroll;
        return control;
    }
}