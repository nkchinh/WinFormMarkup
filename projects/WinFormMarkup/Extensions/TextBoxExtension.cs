namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for TextBox.
/// </summary>
public static class TextBoxExtension
{
    /// <summary>
    ///     Sets the Multiline property and returns the same instance.
    /// </summary>
    /// <param name="textBox">The instance to configure.</param>
    /// <param name="multiLine">The value to assign to Multiline.</param>
    /// <typeparam name="TTextBox">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="textBox" /> instance for fluent composition.</returns>
    public static TTextBox Multiline<TTextBox>(this TTextBox textBox, bool multiLine) where TTextBox : TextBox
    {
        textBox.Multiline = multiLine;
        return textBox;
    }
    
    /// <summary>
    ///     Sets the ReadOnly property and returns the same instance.
    /// </summary>
    /// <param name="textBox">The instance to configure.</param>
    /// <param name="readOnly">The value to assign to ReadOnly.</param>
    /// <typeparam name="TTextBox">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="textBox" /> instance for fluent composition.</returns>
    public static TTextBox ReadOnly<TTextBox>(this TTextBox textBox, bool readOnly) where TTextBox : TextBox
    {
        textBox.ReadOnly = readOnly;
        return textBox;
    }
    
}