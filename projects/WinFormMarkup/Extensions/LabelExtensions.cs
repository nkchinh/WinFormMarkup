namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for Label.
/// </summary>
public static class LabelExtensions
{
    /// <summary>
    ///     Sets the TextAlign property and returns the same instance.
    /// </summary>
    /// <param name="label">The instance to configure.</param>
    /// <param name="alignment">The value to assign to TextAlign.</param>
    /// <typeparam name="TLabel">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="label" /> instance for fluent composition.</returns>
    public static TLabel TextAlign<TLabel>(
        this TLabel label,
        ContentAlignment alignment)
        where TLabel : Label
    {
        label.TextAlign = alignment;
        return label;
    }
}