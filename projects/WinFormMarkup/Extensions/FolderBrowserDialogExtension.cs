namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for FolderBrowserDialog.
/// </summary>
public static class FolderBrowserDialogExtension
{
    /// <summary>
    ///     Sets the Description property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="description">The value to assign to Description.</param>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static FolderBrowserDialog Description(
        this FolderBrowserDialog dialog,
        string description)
    {
        dialog.Description = description;
        return dialog;
    }

    /// <summary>
    ///     Sets the RootFolder property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="rootFolder">The value to assign to RootFolder.</param>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static FolderBrowserDialog RootFolder(
        this FolderBrowserDialog dialog,
        Environment.SpecialFolder rootFolder)
    {
        dialog.RootFolder = rootFolder;
        return dialog;
    }

    /// <summary>
    ///     Sets the SelectedPath property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="selectedPath">The value to assign to SelectedPath.</param>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static FolderBrowserDialog SelectedPath(
        this FolderBrowserDialog dialog,
        string selectedPath)
    {
        dialog.SelectedPath = selectedPath;
        return dialog;
    }

    /// <summary>
    ///     Sets the ShowNewFolderButton property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="newFolderButton">The value to assign to ShowNewFolderButton.</param>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static FolderBrowserDialog ShowNewFolderButton(
        this FolderBrowserDialog dialog,
        bool newFolderButton)
    {
        dialog.ShowNewFolderButton = newFolderButton;
        return dialog;
    }

    /// <summary>
    ///     Configures whether the description is used as the dialog title and returns the dialog.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="descriptionForTitle">Whether to use the description as the title.</param>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static FolderBrowserDialog UseDescriptionForTitle(
        this FolderBrowserDialog dialog,
        bool descriptionForTitle)
    {
#if NET8_0_WINDOWS
        dialog.UseDescriptionForTitle = descriptionForTitle;
#else
        dialog.UseDescriptionForTitle(descriptionForTitle);
#endif
        return dialog;
    }
}
