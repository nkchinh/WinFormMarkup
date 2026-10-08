using System.ComponentModel;

namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent Extensions for Controls
/// </summary>
public static class ControlExtensions
{
    /// <summary>
    ///     Sets the `Control.AccessibleDefaultActionDescription` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="defaultActionDescription">The value to assign to AccessibleDefaultActionDescription.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl AccessibleDefaultActionDescription<TControl>(
        this TControl control,
        string defaultActionDescription)
        where TControl : Control
    {
        control.AccessibleDefaultActionDescription = defaultActionDescription;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.AccessibleDescription` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="accessibleDescription">The value to assign to AccessibleDescription.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl AccessibleDescription<TControl>(
        this TControl control,
        string accessibleDescription)
        where TControl : Control
    {
        control.AccessibleDescription = accessibleDescription;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.AccessibleName` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="accessibleName">The value to assign to AccessibleName.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl AccessibleName<TControl>(
        this TControl control,
        string accessibleName)
        where TControl : Control
    {
        control.AccessibleName = accessibleName;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.AccessibleRole` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="accessibleRole">The value to assign to AccessibleRole.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl AccessibleRole<TControl>(
        this TControl control,
        AccessibleRole accessibleRole)
        where TControl : Control
    {
        control.AccessibleRole = accessibleRole;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.AllowDrop` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="allowDrop">The value to assign to AllowDrop.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl AllowDrop<TControl>(
        this TControl control,
        bool allowDrop)
        where TControl : Control
    {
        control.AllowDrop = allowDrop;
        return control;
    }

    /// <summary>
    ///     Invokes the configuration action immediately and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the current instance.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Also<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        action(control);
        return control;
    }

    /// <summary>
    ///     Sets the `Control.Anchor` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="anchors">The value to assign to Anchor.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Anchor<TControl>(
        this TControl control,
        AnchorStyles anchors)
        where TControl : Control
    {
        control.Anchor = anchors;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.AutoScrollOffset` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="offset">The value to assign to AutoScrollOffset.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl AutoScrollOffset<TControl>(
        this TControl control,
        Point offset)
        where TControl : Control
    {
        control.AutoScrollOffset = offset;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.AutoSize` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="autoSize">Whether automatic sizing is enabled.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl AutoSize<TControl>(
        this TControl control,
        bool autoSize)
        where TControl : Control
    {
        control.AutoSize = autoSize;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.BackColor` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="color">The value to assign to BackColor.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl BackColor<TControl>(
        this TControl control,
        Color color)
        where TControl : Control
    {
        control.BackColor = color;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.BackgroundImage` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="image">The value to assign to BackgroundImage.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl BackgroundImage<TControl>(
        this TControl control,
        Image image)
        where TControl : Control
    {
        control.BackgroundImage = image;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.BackgroundImageLayout` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="layout">The value to assign to BackgroundImageLayout.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl BackgroundImageLayout<TControl>(
        this TControl control,
        ImageLayout layout)
        where TControl : Control
    {
        control.BackgroundImageLayout = layout;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.Bounds` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="bounds">Either two values (width, height), preserving the current position, or four values (left, top, width, height), in pixels.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static TControl Bounds<TControl>(
        this TControl control,
        params int[] bounds)
        where TControl : Control
    {
        if (bounds == null) throw new ArgumentNullException(nameof(bounds));

        switch (bounds.Length)
        {
            case 2:
                control.Bounds = new Rectangle(control.Left, control.Top, bounds[0], bounds[1]);
                break;
            case 4:
                control.Bounds = new Rectangle(bounds[0], bounds[1], bounds[2], bounds[3]);
                break;
            default:
                throw new ArgumentException(
                    "Bounds must be either 2 (width, height), or 4 (left, top, width, height)");
        }

        return control;
    }

    /// <summary>
    ///     Sets the `Control.Capture` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="capture">The value to assign to Capture.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Capture<TControl>(
        this TControl control,
        bool capture)
        where TControl : Control
    {
        control.Capture = capture;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.CausesValidation` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="causesValidation">The value to assign to CausesValidation.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl CausesValidation<TControl>(
        this TControl control,
        bool causesValidation)
        where TControl : Control
    {
        control.CausesValidation = causesValidation;
        return control;
    }


    /// <summary>
    ///     Sets the `Control.ClientSize` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="clientSize">The value to assign to ClientSize.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl ClientSize<TControl>(
        this TControl control,
        Size clientSize)
        where TControl : Control
    {
        control.ClientSize = clientSize;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.ContextMenuStrip` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="contextMenu">The value to assign to ContextMenuStrip.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl ContextMenuStrip<TControl>(
        this TControl control,
        ContextMenuStrip contextMenu)
        where TControl : Control
    {
        control.ContextMenuStrip = contextMenu;
        return control;
    }

    /// <summary>
    ///     Adds all of the `children`to the control, and return the current control.
    /// </summary>
    /// <remarks>Any child control added with a DockStyle.Fill will be brought to front.</remarks>
    /// <param name="control">The instance to configure.</param>
    /// <param name="children">`params` collection of controls to add.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Controls<TControl>(
        this TControl control,
        params Control[] children)
        where TControl : Control
    {
        control.SuspendLayout();
        control.Controls.AddRange(children);
        foreach (var c in children
                     .Where(c => c.Dock == DockStyle.Fill))
            c.BringToFront();

        control.ResumeLayout();
        return control;
    }

    /// <summary>
    ///     Creates a font using the current font family and the specified point size, and returns the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="size">The font size in points.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl FontSize<TControl>(
        this TControl control,
        int size)
        where TControl : Control
    {
        control.Font = new Font(control.Font.FontFamily, size);
        return control;
    }
    
    /// <summary>
    ///     Sets the `Control.Cursor` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="cursor">The value to assign to Cursor.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Cursor<TControl>(
        this TControl control,
        Cursor cursor)
        where TControl : Control
    {
        control.Cursor = cursor;
        return control;
    }

    /// <summary>
    ///     Sets the `Control.Dock` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="dockPosition">The value to assign to Dock.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Dock<TControl>(
        this TControl control,
        DockStyle dockPosition)
        where TControl : Control
    {
        control.Dock = dockPosition;
        return control;
    }

    /// <summary>
    ///     Sets the Enabled property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="enabled">The value to assign to Enabled.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Enabled<TControl>(
        this TControl control,
        bool enabled)
        where TControl : Control
    {
        control.Enabled = enabled;
        return control;
    }

    /// <summary>
    ///     Sets the Font property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="font">The value to assign to Font.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Font<TControl>(
        this TControl control,
        Font font)
        where TControl : Control
    {
        control.Font = font;
        return control;
    }

    /// <summary>
    ///     Sets the ForeColor property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="foreColor">The value to assign to ForeColor.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl ForeColor<TControl>(
        this TControl control,
        Color foreColor)
        where TControl : Control
    {
        control.ForeColor = foreColor;
        return control;
    }

    /// <summary>
    ///     Sets the Height property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="height">The height in pixels.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Height<TControl>(
        this TControl control,
        int height)
        where TControl : Control
    {
        control.Height = height;
        return control;
    }

    /// <summary>
    ///     Sets the ImeMode property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="mode">The value to assign to ImeMode.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl ImeMode<TControl>(
        this TControl control,
        ImeMode mode)
        where TControl : Control
    {
        control.ImeMode = mode;
        return control;
    }


    /// <summary>
    ///     Sets the IsAccessible property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="isAccessible">The value to assign to IsAccessible.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl IsAccessible<TControl>(
        this TControl control,
        bool isAccessible)
        where TControl : Control
    {
        control.IsAccessible = isAccessible;
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the Leave event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Leave<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.Leave += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Sets the Left property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="left">The left in pixels.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Left<TControl>(
        this TControl control,
        int left)
        where TControl : Control
    {
        control.Left = left;
        return control;
    }

    /// <summary>
    ///     Sets the Location property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="location">The value to assign to Location.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Location<TControl>(
        this TControl control,
        Point location)
        where TControl : Control
    {
        control.Location = location;
        return control;
    }

    /// <summary>
    ///     Sets the Location property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="left">The left in pixels.</param>
    /// <param name="top">The top in pixels.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Location<TControl>(
        this TControl control,
        int left,
        int top)
        where TControl : Control
    {
        control.Location = new Point(left, top);

        return control;
    }

    /// <summary>
    ///     Sets the `Control.Margin` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="margin">Variable number of parameters 1 (all), 2 (horizontal, vertical), or 4 (left, top, right, bottom)</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static TControl Margin<TControl>(
        this TControl control,
        params int[] margin)
        where TControl : Control
    {
        if (margin == null) throw new ArgumentNullException(nameof(margin));

        switch (margin.Length)
        {
            case 1:
                control.Margin = new Padding(margin[0]);
                break;
            case 2:
                control.Margin = new Padding(margin[0], margin[1], margin[0], margin[1]);
                break;
            case 4:
                control.Margin = new Padding(margin[0], margin[1], margin[2], margin[3]);
                break;
            default:
                throw new ArgumentException(
                    "Margin must be either 1 (all), 2 (horizontal, vertical), or 4 (left, top, right, bottom)");
        }

        return control;
    }


    /// <summary>
    ///     Sets the MaximumSize property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="size">The value to assign to MaximumSize.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl MaximumSize<TControl>(
        this TControl control,
        Size size)
        where TControl : Control
    {
        control.MaximumSize = size;
        return control;
    }

    /// <summary>
    ///     Sets the MaximumSize property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="width">The width in pixels.</param>
    /// <param name="height">The height in pixels.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl MaximumSize<TControl>(
        this TControl control,
        int width,
        int height)
        where TControl : Control
    {
        return control.MaximumSize(new Size(width, height));
    }

    /// <summary>
    ///     Sets the MinimumSize property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="size">The value to assign to MinimumSize.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl MinimumSize<TControl>(
        this TControl control,
        Size size)
        where TControl : Control
    {
        control.MinimumSize = size;
        return control;
    }

    /// <summary>
    ///     Sets the MinimumSize property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="width">The width in pixels.</param>
    /// <param name="height">The height in pixels.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl MinimumSize<TControl>(
        this TControl control,
        int width,
        int height)
        where TControl : Control
    {
        return control.MinimumSize(new Size(width, height));
    }

    /// <summary>
    ///     Sets the Name property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="name">The value to assign to Name.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Name<TControl>(
        this TControl control,
        string name)
        where TControl : Control
    {
        control.Name = name;
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.AutoSizeChanged` event to call the provided `action`, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnAutoSizeChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.AutoSizeChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }


    /// <summary>
    ///     Hooks the `Control.BackColorChanged` event to call the provided `action`, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnBackColorChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.BackColorChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.BackgroundImageChanged` event to call the provided `action`, and returns a reference to the
    ///     control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnBackgroundImageChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.BackgroundImageChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.BackgroundImageLayoutChanged` event to call the provided `action`, and returns a reference to
    ///     the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnBackgroundImageLayoutChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.BackgroundImageLayoutChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.BindingContextChanged` event to call the provided `action`, and returns a reference to the
    ///     control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnBindingContextChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.BindingContextChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.CausesValidationChanged` event to call the provided `action`, and returns a reference to the
    ///     control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnCausesValidationChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.CausesValidationChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }


    // ReSharper disable once InconsistentNaming
    /// <summary>
    ///     Subscribes the action to the ChangeUICues event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnChangeUICues<TControl>(
        this TControl control,
        Action<TControl, UICuesEventArgs> action)
        where TControl : Control
    {
        control.ChangeUICues += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.Click` event to call the provided `action`, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnClick<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.Click += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.ClientSizeChanged` event to call the provided `action`, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnClientSizeChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.ClientSizeChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.ContextMenuStripChanged` event to call the provided `action`, and returns a reference to the
    ///     control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnContextMenuStripChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.ContextMenuStripChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.ControlAdded` event to call the provided `action`, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnControlAdded<TControl>(
        this TControl control,
        Action<TControl, ControlEventArgs> action)
        where TControl : Control
    {
        control.ControlAdded += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.ControlRemoved` event to call the provided `action`, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnControlRemoved<TControl>(
        this TControl control,
        Action<TControl, ControlEventArgs> action)
        where TControl : Control
    {
        control.ControlRemoved += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.CursorChanged` event to call the provided `action`, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnCursorChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.CursorChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.DockChanged` event to call the provided `action`, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnDockChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.DockChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Hooks the `Control.DoubleClick` event to call the provided `action`, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnDoubleClick<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.DoubleClick += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the DragDrop event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnDragDrop<TControl>(
        this TControl control,
        Action<TControl, DragEventArgs> action)
        where TControl : Control
    {
        control.DragDrop += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the DragEnter event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnDragEnter<TControl>(
        this TControl control,
        Action<TControl, DragEventArgs> action)
        where TControl : Control
    {
        control.DragEnter += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the DragLeave event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnDragLeave<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.DragLeave += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the DragOver event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnDragOver<TControl>(
        this TControl control,
        Action<TControl, DragEventArgs> action)
        where TControl : Control
    {
        control.DragOver += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the EnabledChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnEnabledChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.EnabledChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the Enter event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnEnter<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.Enter += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the FontChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnFontChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.FontChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the ForeColorChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnForeColorChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.ForeColorChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the GiveFeedback event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnGiveFeedback<TControl>(
        this TControl control,
        Action<TControl, GiveFeedbackEventArgs> action)
        where TControl : Control
    {
        control.GiveFeedback += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the GotFocus event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnGotFocus<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.GotFocus += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the HandleCreated event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnHandleCreated<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.HandleCreated += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the HandleDestroyed event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnHandleDestroyed<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.HandleDestroyed += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the HelpRequested event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnHelpRequested<TControl>(
        this TControl control,
        Action<TControl, HelpEventArgs> action)
        where TControl : Control
    {
        control.HelpRequested += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the ImeModeChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnImeModeChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.ImeModeChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the Invalidated event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnInvalidated<TControl>(
        this TControl control,
        Action<TControl, InvalidateEventArgs> action)
        where TControl : Control
    {
        control.Invalidated += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the KeyDown event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnKeyDown<TControl>(
        this TControl control,
        Action<TControl, KeyEventArgs> action)
        where TControl : Control
    {
        control.KeyDown += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the KeyPress event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnKeyPress<TControl>(
        this TControl control,
        Action<TControl, KeyPressEventArgs> action)
        where TControl : Control
    {
        control.KeyPress += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the KeyUp event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnKeyUp<TControl>(
        this TControl control,
        Action<TControl, KeyEventArgs> action)
        where TControl : Control
    {
        control.KeyUp += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the Layout event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnLayout<TControl>(
        this TControl control,
        Action<TControl, LayoutEventArgs> action)
        where TControl : Control
    {
        control.Layout += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the LocationChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnLocationChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.LocationChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the LostFocus event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnLostFocus<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.LostFocus += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the MarginChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMarginChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.MarginChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the MouseCaptureChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMouseCaptureChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.MouseCaptureChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the MouseClick event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMouseClick<TControl>(
        this TControl control,
        Action<TControl, MouseEventArgs> action)
        where TControl : Control
    {
        control.MouseClick += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the MouseDoubleClick event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMouseDoubleClick<TControl>(
        this TControl control,
        Action<TControl, MouseEventArgs> action)
        where TControl : Control
    {
        control.MouseDoubleClick += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the MouseDown event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMouseDown<TControl>(
        this TControl control,
        Action<TControl, MouseEventArgs> action)
        where TControl : Control
    {
        control.MouseDown += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the MouseEnter event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMouseEnter<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.MouseEnter += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the MouseHover event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMouseHover<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.MouseHover += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the MouseLeave event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMouseLeave<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.MouseLeave += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the MouseMove event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMouseMove<TControl>(
        this TControl control,
        Action<TControl, MouseEventArgs> action)
        where TControl : Control
    {
        control.MouseMove += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the MouseUp event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMouseUp<TControl>(
        this TControl control,
        Action<TControl, MouseEventArgs> action)
        where TControl : Control
    {
        control.MouseUp += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the MouseWheel event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMouseWheel<TControl>(
        this TControl control,
        Action<TControl, MouseEventArgs> action)
        where TControl : Control
    {
        control.MouseWheel += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the Move event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnMove<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.Move += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the PaddingChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnPaddingChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.PaddingChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the Paint event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnPaint<TControl>(
        this TControl control,
        Action<TControl, PaintEventArgs> action)
        where TControl : Control
    {
        control.Paint += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the ParentChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnParentChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.ParentChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the PreviewKeyDown event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnPreviewKeyDown<TControl>(
        this TControl control,
        Action<TControl, PreviewKeyDownEventArgs> action)
        where TControl : Control
    {
        control.PreviewKeyDown += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the QueryAccessibilityHelp event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnQueryAccessibilityHelp<TControl>(
        this TControl control,
        Action<TControl, QueryAccessibilityHelpEventArgs> action)
        where TControl : Control
    {
        control.QueryAccessibilityHelp += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the QueryContinueDrag event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnQueryContinueDrag<TControl>(
        this TControl control,
        Action<TControl, QueryContinueDragEventArgs> action)
        where TControl : Control
    {
        control.QueryContinueDrag += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the RegionChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnRegionChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.RegionChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the Resize event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnResize<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.Resize += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the RightToLeftChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl ONRightToLeftChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.RightToLeftChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the SizeChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnSizeChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.SizeChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the StyleChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnStyleChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.StyleChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the SystemColorsChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnSystemColorsChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.SystemColorsChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the TabIndexChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnTabIndexChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.TabIndexChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the TabStopChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnTabStopChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.TabStopChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the TextChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnTextChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.TextChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the Validated event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnValidated<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.Validated += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Subscribes the action to the VisibleChanged event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl OnVisibleChanged<TControl>(
        this TControl control,
        Action<TControl> action)
        where TControl : Control
    {
        control.VisibleChanged += (sender, _) => action.Invoke((sender as TControl)!);
        return control;
    }

    /// <summary>
    ///     Sets the `Control.Padding` property, and returns a reference to the control.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="padding">Variable number of parameters 1 (all), 2 (horizontal, vertical), or 4 (left, top, right, bottom)</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static TControl Padding<TControl>(
        this TControl control,
        params int[] padding)
        where TControl : Control
    {
        if (padding == null) throw new ArgumentNullException(nameof(padding));

        switch (padding.Length)
        {
            case 1:
                control.Padding = new Padding(padding[0]);
                break;
            case 2:
                control.Padding = new Padding(padding[0], padding[1], padding[0], padding[1]);
                break;
            case 4:
                control.Padding = new Padding(padding[0], padding[1], padding[2], padding[3]);
                break;
            default:
                throw new ArgumentException(
                    "Padding must be either 1 (all), 2 (horizontal, vertical), or 4 (left, top, right, bottom)");
        }

        return control;
    }


    /// <summary>
    ///     Sets the Parent property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="parent">The value to assign to Parent.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Parent<TControl>(
        this TControl control,
        Control parent)
        where TControl : Control
    {
        control.Parent = parent;
        return control;
    }

    /// <summary>
    ///     Sets the Region property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="region">The value to assign to Region.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Region<TControl>(
        this TControl control,
        Region region)
        where TControl : Control
    {
        control.Region = region;
        return control;
    }

    /// <summary>
    ///     Sets the RightToLeft property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="rtl">The value to assign to RightToLeft.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl RightToLeft<TControl>(
        this TControl control,
        RightToLeft rtl)
        where TControl : Control
    {
        control.RightToLeft = rtl;
        return control;
    }

    /// <summary>
    ///     Sets the Site property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="site">The value to assign to Site.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Site<TControl>(
        this TControl control,
        ISite site)
        where TControl : Control
    {
        control.Site = site;
        return control;
    }


    /// <summary>
    ///     Sets the Size property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="size">The value to assign to Size.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Size<TControl>(
        this TControl control,
        Size size)
        where TControl : Control
    {
        control.Size = size;
        return control;
    }


    /// <summary>
    ///     Sets the Size property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="width">The width in pixels.</param>
    /// <param name="height">The height in pixels.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Size<TControl>(
        this TControl control,
        int width,
        int height)
        where TControl : Control
    {
        return control.Size(new Size(width, height));
    }

    /// <summary>
    ///     Sets the TabIndex property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="tabIndex">The value to assign to TabIndex.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl TabIndex<TControl>(
        this TControl control,
        int tabIndex)
        where TControl : Control
    {
        control.TabIndex = tabIndex;
        return control;
    }

    /// <summary>
    ///     Sets the TabStop property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="tabStop">The value to assign to TabStop.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl TabStop<TControl>(
        this TControl control,
        bool tabStop)
        where TControl : Control
    {
        control.TabStop = tabStop;
        return control;
    }


    /// <summary>
    ///     Sets the Tag property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="tag">The value to assign to Tag.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Tag<TControl>(
        this TControl control,
        object tag)
        where TControl : Control
    {
        control.Tag = tag;
        return control;
    }

    /// <summary>
    ///     Sets the Text property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="text">The value to assign to Text.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Text<TControl>(
        this TControl control,
        string text)
        where TControl : Control
    {
        control.Text = text;
        return control;
    }

    /// <summary>
    ///     Sends the current control to the back of the parent controls collection.
    ///     If the control has already been assigned to a parent, then this method calls `SendToBack()` immediately and returns
    ///     a reference to the control.
    ///     Otherwise, if hooks the `Control.ParentChanged` event, and then invokes `SendToBack()` when the parent is assigned.
    /// </summary>
    /// <remarks>
    ///     **NOTE:** Thread-safe.  Automatically unhooks from event after `ParentChanged` has fired.
    /// </remarks>
    /// <param name="control">The instance to configure.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl ToBack<TControl>(
        this TControl control)
        where TControl : Control
    {
        void DoToBack(object? o, EventArgs eventArgs)
        {
            control.SendToBack();
            control.ParentChanged -= DoToBack;
        }

        if (control.Parent == null)
            control.ParentChanged += DoToBack;
        else
            control.BeginInvoke((EventHandler)DoToBack);

        return control;
    }

    /// <summary>
    ///     Brings the current control to the front of the parent controls collection.
    ///     If the control has already been assigned to a parent, then this method calls `BringToFront()` immediately and
    ///     returns a reference to the control.
    ///     Otherwise, if hooks the `Control.ParentChanged` event, and then invokes `BringToFront()` when the parent is
    ///     assigned.
    /// </summary>
    /// <remarks>
    ///     **NOTE:** Thread-safe.  Automatically unhooks from event after `ParentChanged` has fired.
    /// </remarks>
    /// <param name="control">The instance to configure.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl ToFront<TControl>(
        this TControl control)
        where TControl : Control
    {
        void DoToFront(object? o, EventArgs eventArgs)
        {
            control.BringToFront();
            control.ParentChanged -= DoToFront;
        }

        if (control.Parent == null)
            control.ParentChanged += DoToFront;
        else
            control.BeginInvoke((EventHandler)DoToFront);

        return control;
    }


    /// <summary>
    ///     Sets the Top property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="top">The top in pixels.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Top<TControl>(
        this TControl control,
        int top)
        where TControl : Control
    {
        control.Top = top;
        return control;
    }

    /// <summary>
    ///     Sets the UseWaitCursor property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="useWait">The value to assign to UseWaitCursor.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl UseWaitCursor<TControl>(
        this TControl control,
        bool useWait)
        where TControl : Control
    {
        control.UseWaitCursor = useWait;
        return control;
    }


    /// <summary>
    ///     Subscribes the action to the Validating event and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender and event data.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Validating<TControl>(
        this TControl control,
        Action<TControl, CancelEventArgs> action)
        where TControl : Control
    {
        control.Validating += (sender, args) => action.Invoke((sender as TControl)!, args);
        return control;
    }

    /// <summary>
    ///     Sets the Visible property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="visible">The value to assign to Visible.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Visible<TControl>(
        this TControl control,
        bool visible)
        where TControl : Control
    {
        control.Visible = visible;
        return control;
    }

    /// <summary>
    ///     Sets the Width property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="width">The width in pixels.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl Width<TControl>(
        this TControl control,
        int width)
        where TControl : Control
    {
        control.Width = width;
        return control;
    }


    /// <summary>
    ///     Sets the WindowTarget property and returns the same instance.
    /// </summary>
    /// <param name="control">The instance to configure.</param>
    /// <param name="target">The value to assign to WindowTarget.</param>
    /// <typeparam name="TControl">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="control" /> instance for fluent composition.</returns>
    public static TControl WindowTarget<TControl>(
        this TControl control,
        IWindowTarget target)
        where TControl : Control
    {
        control.WindowTarget = target;
        return control;
    }
}
