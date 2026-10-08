using System.ComponentModel;

namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for FileDialogs
///     <para>Inherits: <see cref="WinFormMarkup.Extensions.CommonDialogExtensions" /></para>
/// </summary>
public static class FileDialogExtensions
{
    /// <summary>
    ///     Sets the CheckFileExists property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="checkExists">The value to assign to CheckFileExists.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog CheckFileExists<TFileDialog>(
        this TFileDialog dialog,
        bool checkExists)
        where TFileDialog : FileDialog
    {
        dialog.CheckFileExists = checkExists;
        return dialog;
    }

    /// <summary>
    ///     Sets the CheckPathExists property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="checkExists">The value to assign to CheckPathExists.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog CheckPathExists<TFileDialog>(
        this TFileDialog dialog,
        bool checkExists)
        where TFileDialog : FileDialog
    {
        dialog.CheckPathExists = checkExists;
        return dialog;
    }


    /// <summary>
    ///     Appends the supplied custom places to the file dialog and returns the dialog.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="places">The places to add.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog CustomPlaces<TFileDialog>(
        this TFileDialog dialog,
        params string[] places)
        where TFileDialog : FileDialog
    {
        foreach (var place in places) dialog.CustomPlaces.Add(place);

        return dialog;
    }

    /// <summary>
    ///     Appends the supplied custom places to the file dialog and returns the dialog.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="places">The places to add.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog CustomPlaces<TFileDialog>(
        this TFileDialog dialog,
        params Guid[] places)
        where TFileDialog : FileDialog
    {
        foreach (var place in places) dialog.CustomPlaces.Add(place);

        return dialog;
    }


    /// <summary>
    ///     Appends the supplied custom places to the file dialog and returns the dialog.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="places">The places to add.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog CustomPlaces<TFileDialog>(
        this TFileDialog dialog,
        params FileDialogCustomPlace[] places)
        where TFileDialog : FileDialog
    {
        foreach (var place in places) dialog.CustomPlaces.Add(place);

        return dialog;
    }

    /// <summary>
    ///     Sets the DefaultExt property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="defaultExt">The value to assign to DefaultExt.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog DefaultExt<TFileDialog>(
        this TFileDialog dialog,
        string defaultExt)
        where TFileDialog : FileDialog
    {
        dialog.DefaultExt = defaultExt;
        return dialog;
    }

    /// <summary>
    ///     Sets the FileName property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="fileName">The value to assign to FileName.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog FileName<TFileDialog>(
        this TFileDialog dialog,
        string fileName)
        where TFileDialog : FileDialog
    {
        dialog.FileName = fileName;
        return dialog;
    }

    /// <summary>
    ///     Sets the Filter property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="filter">The value to assign to Filter.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog Filter<TFileDialog>(
        this TFileDialog dialog,
        string filter)
        where TFileDialog : FileDialog
    {
        dialog.Filter = filter;
        return dialog;
    }

    /// <summary>
    ///     Sets the InitialDirectory property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="initialPath">The value to assign to InitialDirectory.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog InitialDirectory<TFileDialog>(
        this TFileDialog dialog,
        string initialPath)
        where TFileDialog : FileDialog
    {
        dialog.InitialDirectory = initialPath;
        return dialog;
    }

    /// <summary>
    ///     Subscribes the action to the FileOk event and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog OnFileOk<TFileDialog>(
        this TFileDialog dialog,
        Action<TFileDialog, CancelEventArgs> action)
        where TFileDialog : FileDialog
    {
        dialog.FileOk += (sender, args) => action.Invoke((sender as TFileDialog)!, args);
        return dialog;
    }

    /// <summary>
    ///     Sets the RestoreDirectory property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="restore">The value to assign to RestoreDirectory.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog RestoreDirectory<TFileDialog>(
        this TFileDialog dialog,
        bool restore)
        where TFileDialog : FileDialog
    {
        dialog.RestoreDirectory = restore;
        return dialog;
    }

    /// <summary>
    ///     Sets the ShowHelp property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="showHelp">The value to assign to ShowHelp.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog ShowHelp<TFileDialog>(
        this TFileDialog dialog,
        bool showHelp)
        where TFileDialog : FileDialog
    {
        dialog.ShowHelp = showHelp;
        return dialog;
    }


    /// <summary>
    ///     Sets the SupportMultiDottedExtensions property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="multiDot">The value to assign to SupportMultiDottedExtensions.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog SupportMultiDottedExtensions<TFileDialog>(
        this TFileDialog dialog,
        bool multiDot)
        where TFileDialog : FileDialog
    {
        dialog.SupportMultiDottedExtensions = multiDot;
        return dialog;
    }

    /// <summary>
    ///     Sets the Title property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="title">The value to assign to Title.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog Title<TFileDialog>(
        this TFileDialog dialog,
        string title)
        where TFileDialog : FileDialog
    {
        dialog.Title = title;
        return dialog;
    }

    /// <summary>
    ///     Sets the ValidateNames property and returns the same instance.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="validate">The value to assign to ValidateNames.</param>
    /// <typeparam name="TFileDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TFileDialog ValidateNames<TFileDialog>(
        this TFileDialog dialog,
        bool validate)
        where TFileDialog : FileDialog
    {
        dialog.ValidateNames = validate;
        return dialog;
    }
}