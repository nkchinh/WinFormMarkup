namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for SplitterControl.
/// </summary>
public static class SplitterControlExtension
{
    /// <summary>
    ///     Adds the supplied controls to the first split-container panel and returns the split container.
    /// </summary>
    /// <param name="splitContainer">The instance to configure.</param>
    /// <param name="controls">The controls to add.</param>
    /// <typeparam name="TSplitContainer">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="splitContainer" /> instance for fluent composition.</returns>
    public static TSplitContainer Panel1<TSplitContainer>(this TSplitContainer splitContainer,
        params Control[] controls) where TSplitContainer : SplitContainer
    {
        splitContainer.Panel1.Controls(controls);
        return splitContainer;
    }

    /// <summary>
    ///     Adds the supplied controls to the second split-container panel and returns the split container.
    /// </summary>
    /// <param name="splitContainer">The instance to configure.</param>
    /// <param name="controls">The controls to add.</param>
    /// <typeparam name="TSplitContainer">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="splitContainer" /> instance for fluent composition.</returns>
    public static TSplitContainer Panel2<TSplitContainer>(this TSplitContainer splitContainer,
        params Control[] controls) where TSplitContainer : SplitContainer
    {
        splitContainer.Panel2.Controls(controls);
        return splitContainer;
    }

    /// <summary>
    ///     Sets the SplitterDistance property and returns the same instance.
    /// </summary>
    /// <param name="splitContainer">The instance to configure.</param>
    /// <param name="distance">The value to assign to SplitterDistance.</param>
    /// <typeparam name="TSplitContainer">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="splitContainer" /> instance for fluent composition.</returns>
    public static TSplitContainer SplitterDistance<TSplitContainer>(this TSplitContainer splitContainer, int distance)
        where TSplitContainer : SplitContainer
    {
        splitContainer.SplitterDistance = distance;
        return splitContainer;
    }
}