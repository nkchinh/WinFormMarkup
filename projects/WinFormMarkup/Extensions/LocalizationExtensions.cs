using System.ComponentModel;

namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for localizing WinForms components.
/// </summary>
public static class LocalizationExtensions
{
    /// <summary>
    ///     Applies localized resources to the current Form or UserControl using the <c>$this</c> resource key, and returns the resource manager for localizing its components.
    /// </summary>
    /// <param name="control">The control to localize.</param>
    /// <param name="resources">The resource manager created for the current Form or UserControl.</param>
    /// <typeparam name="TControl">A WinForms control.</typeparam>
    /// <returns>The localized control.</returns>
    public static TControl Localize<TControl>(
        this TControl control,
        out ComponentResourceManager resources)
        where TControl : Control
    {
        return control.Localize("$this", out resources);
    }

    /// <summary>
    ///     Applies localized resources to the current Form or UserControl and returns the resource manager for localizing its components.
    /// </summary>
    /// <param name="control">The control to localize.</param>
    /// <param name="objectName">The control's resource key in the .resx file.</param>
    /// <param name="resources">The resource manager created for the current Form or UserControl.</param>
    /// <typeparam name="TControl">A WinForms control.</typeparam>
    /// <returns>The localized control.</returns>
    public static TControl Localize<TControl>(
        this TControl control,
        string objectName,
        out ComponentResourceManager resources)
        where TControl : Control
    {
        resources = new ComponentResourceManager(control.GetType());
        resources.ApplyResources(control, objectName);
        return control;
    }

    /// <summary>
    ///     Applies localized resources to a component and returns the component for fluent composition.
    /// </summary>
    /// <param name="component">The component to localize.</param>
    /// <param name="resources">The shared resource manager for the form.</param>
    /// <param name="objectName">The component's resource key in the .resx file.</param>
    /// <typeparam name="TComponent">A WinForms component.</typeparam>
    /// <returns>The localized component.</returns>
    public static TComponent Localize<TComponent>(
        this TComponent component,
        ComponentResourceManager resources,
        string objectName)
        where TComponent : Component
    {
        resources.ApplyResources(component, objectName);
        return component;
    }
}
