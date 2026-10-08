namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for OpenFileDialog.
/// </summary>
public static class OpenFileDialogExtensions
{
    /// <summary>
    ///     Sets the Multiselect property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="multiselect">The value to assign to Multiselect.</param>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static OpenFileDialog Multiselect(
        this OpenFileDialog dialog,
        bool multiselect)
    {
        dialog.Multiselect = multiselect;
        return dialog;
    }

    /// <summary>
    ///     Sets the ReadOnlyChecked property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="readOnlyChecked">The value to assign to ReadOnlyChecked.</param>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static OpenFileDialog ReadOnlyChecked(
        this OpenFileDialog dialog,
        bool readOnlyChecked)
    {
        dialog.ReadOnlyChecked = readOnlyChecked;
        return dialog;
    }

    /// <summary>
    ///     Sets the ShowReadOnly property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="showReadOnly">The value to assign to ShowReadOnly.</param>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static OpenFileDialog ShowReadOnly(
        this OpenFileDialog dialog,
        bool showReadOnly)
    {
        dialog.ShowReadOnly = showReadOnly;
        return dialog;
    }
}