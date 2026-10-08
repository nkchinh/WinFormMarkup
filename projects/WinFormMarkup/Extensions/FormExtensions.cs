namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for Form.
/// </summary>
public static class FormExtensions
{
    /// <summary>
    ///     Sets the AcceptButton property and returns the same instance.
    /// </summary>
    /// <param name="form">The instance to configure.</param>
    /// <param name="acceptButton">The value to assign to AcceptButton.</param>
    /// <typeparam name="TForm">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="form" /> instance for fluent composition.</returns>
    public static TForm AcceptButton<TForm>(
        this TForm form,
        Button acceptButton)
        where TForm : Form
    {
        form.AcceptButton = acceptButton;
        return form;
    }

    /// <summary>
    ///     Sets automatic sizing and, when enabled, its sizing mode, and returns the form.
    /// </summary>
    /// <param name="form">The instance to configure.</param>
    /// <param name="autoSize">Whether automatic sizing is enabled.</param>
    /// <param name="mode">The sizing mode to apply when automatic sizing is enabled.</param>
    /// <typeparam name="TForm">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="form" /> instance for fluent composition.</returns>
    public static TForm AutoSize<TForm>(
        this TForm form,
        bool autoSize,
        AutoSizeMode mode
    )
        where TForm : Form
    {
        form.AutoSize = autoSize;
        if (autoSize) form.AutoSizeMode = mode;

        return form;
    }

    /// <summary>
    ///     Sets the CancelButton property and returns the same instance.
    /// </summary>
    /// <param name="form">The instance to configure.</param>
    /// <param name="cancelButton">The value to assign to CancelButton.</param>
    /// <typeparam name="TForm">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="form" /> instance for fluent composition.</returns>
    public static TForm CancelButton<TForm>(
        this TForm form,
        Button cancelButton)
        where TForm : Form
    {
        form.CancelButton = cancelButton;
        return form;
    }

    /// <summary>
    ///     Sets the Icon property and returns the same instance.
    /// </summary>
    /// <param name="form">The instance to configure.</param>
    /// <param name="icon">The value to assign to Icon.</param>
    /// <typeparam name="TForm">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="form" /> instance for fluent composition.</returns>
    public static TForm Icon<TForm>(
        this TForm form,
        Icon icon)
        where TForm : Form
    {
        form.Icon = icon;
        return form;
    }

    /// <summary>
    ///     Creates and attaches a menu strip containing the supplied items, assigns it as the main menu, and returns the form.
    /// </summary>
    /// <param name="form">The instance to configure.</param>
    /// <param name="items">The items to add.</param>
    /// <typeparam name="TForm">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="form" /> instance for fluent composition.</returns>
    public static TForm MainMenuStrip<TForm>(
        this TForm form,
        params ToolStripItem[] items)
        where TForm : Form
    {
        var ms = new MenuStrip().Items(items);
        form.Controls(ms);
        form.MainMenuStrip = ms;
        return form;
    }

    /// <summary>
    ///     Sets the StartPosition property and returns the same instance.
    /// </summary>
    /// <param name="form">The instance to configure.</param>
    /// <param name="startPosition">The value to assign to StartPosition.</param>
    /// <typeparam name="TForm">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="form" /> instance for fluent composition.</returns>
    public static TForm StartPosition<TForm>(
        this TForm form,
        FormStartPosition startPosition)
        where TForm : Form
    {
        form.StartPosition = startPosition;
        return form;
    }

    /// <summary>
    ///     Creates and attaches a status strip containing the supplied items, and returns the form.
    /// </summary>
    /// <param name="form">The instance to configure.</param>
    /// <param name="items">The items to add.</param>
    /// <typeparam name="TForm">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="form" /> instance for fluent composition.</returns>
    public static TForm StatusStrip<TForm>(
        this TForm form,
        params ToolStripItem[] items)
        where TForm : Form
    {
        form.Controls(new StatusStrip().Items(items));
        return form;
    }
}
