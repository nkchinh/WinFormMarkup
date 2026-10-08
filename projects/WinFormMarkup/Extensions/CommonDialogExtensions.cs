namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for CommonDialogs
/// </summary>
public static class CommonDialogExtensions
{
    /// <summary>
    ///     Subscribes the action to the HelpRequest event and returns the dialog.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <param name="action">The action invoked with the event sender.</param>
    /// <typeparam name="TCommonDialog">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="dialog" /> instance for fluent composition.</returns>
    public static TCommonDialog OnHelpRequest<TCommonDialog>(
        this TCommonDialog dialog,
        Action<TCommonDialog> action)
        where TCommonDialog : CommonDialog
    {
        dialog.HelpRequest += (sender, _) => action.Invoke((sender as TCommonDialog)!);
        return dialog;
    }

    /// <summary>
    ///     Shows the dialog modally and returns the dialog together with its result.
    /// </summary>
    /// <param name="dialog">The instance to configure.</param>
    /// <typeparam name="TCommonDialog">The concrete type of the instance.</typeparam>
    /// <returns>The dialog and the result returned by its modal display.</returns>
    public static DialogInfo<TCommonDialog> Show<TCommonDialog>(
        this TCommonDialog dialog)
        where TCommonDialog : CommonDialog
    {
        return new DialogInfo<TCommonDialog>(dialog, dialog.ShowDialog());
    }
}

#if NET8_0_WINDOWS
/// <summary>Contains a dialog and the result of displaying it.</summary>
/// <typeparam name="TDialog">The dialog type.</typeparam>
/// <param name="Dialog">The dialog that was displayed.</param>
/// <param name="Result">The result of displaying the dialog.</param>
public record DialogInfo<TDialog>(TDialog Dialog, DialogResult Result);
#else
/// <summary>Contains a dialog and the result of displaying it.</summary>
/// <typeparam name="TDialog">The dialog type.</typeparam>
public sealed class DialogInfo<TDialog> : IEquatable<DialogInfo<TDialog>>
{
    /// <summary>Initializes a dialog result pair.</summary>
    /// <param name="dialog">The dialog that was displayed.</param>
    /// <param name="result">The result of displaying the dialog.</param>
    public DialogInfo(TDialog dialog, DialogResult result)
    {
        Dialog = dialog;
        Result = result;
    }

    /// <summary>Gets the dialog that was displayed.</summary>
    public TDialog Dialog { get; }
    /// <summary>Gets the result of displaying the dialog.</summary>
    public DialogResult Result { get; }

    /// <summary>Deconstructs the pair into its dialog and result.</summary>
    /// <param name="dialog">The dialog that was displayed.</param>
    /// <param name="result">The result of displaying the dialog.</param>
    public void Deconstruct(out TDialog dialog, out DialogResult result)
    {
        dialog = Dialog;
        result = Result;
    }

    /// <summary>Compares the dialog and result using their default equality semantics.</summary>
    /// <param name="other">The pair to compare with this instance.</param>
    /// <returns>True when both values are equal; otherwise, false.</returns>
    public bool Equals(DialogInfo<TDialog>? other) =>
        other is not null && EqualityComparer<TDialog>.Default.Equals(Dialog, other.Dialog) && Result == other.Result;

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is DialogInfo<TDialog> other && Equals(other);

    /// <inheritdoc />
    public override int GetHashCode()
    {
        unchecked
        {
            return ((Dialog is null ? 0 : EqualityComparer<TDialog>.Default.GetHashCode(Dialog)) * 397) ^ (int)Result;
        }
    }
}
#endif
