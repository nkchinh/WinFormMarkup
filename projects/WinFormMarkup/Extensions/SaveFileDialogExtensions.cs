namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for SaveFileDialog.
/// </summary>
public static class SaveFileDialogExtensions
{
    /// <summary>
    ///     Sets the CreatePrompt property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="createPrompt">The value to assign to CreatePrompt.</param>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static SaveFileDialog CreatePrompt(
        this SaveFileDialog dialog,
        bool createPrompt)
    {
        dialog.CreatePrompt = createPrompt;
        return dialog;
    }

    /// <summary>
    ///     Sets the OverwritePrompt property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="overwritePrompt">The value to assign to OverwritePrompt.</param>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static SaveFileDialog OverwritePrompt(
        this SaveFileDialog dialog,
        bool overwritePrompt)
    {
        dialog.OverwritePrompt = overwritePrompt;
        return dialog;
    }
}