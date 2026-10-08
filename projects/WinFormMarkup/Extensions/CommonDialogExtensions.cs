namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for CommonDialogs
/// </summary>
public static class CommonDialogExtensions
{
    /// <summary>
    ///     Assign property in a fluent manner
    /// </summary>
    /// <param name="dialog"></param>
    /// <param name="action"></param>
    /// <typeparam name="TCommonDialog"></typeparam>
    /// <returns></returns>
    public static TCommonDialog OnHelpRequest<TCommonDialog>(
        this TCommonDialog dialog,
        Action<TCommonDialog> action)
        where TCommonDialog : CommonDialog
    {
        dialog.HelpRequest += (sender, _) => action.Invoke((sender as TCommonDialog)!);
        return dialog;
    }

    public static DialogInfo<TCommonDialog> Show<TCommonDialog>(
        this TCommonDialog dialog)
        where TCommonDialog : CommonDialog
    {
        return new DialogInfo<TCommonDialog>(dialog, dialog.ShowDialog());
    }
}

#if NET8_0_WINDOWS
public record DialogInfo<TDialog>(TDialog Dialog, DialogResult Result);
#else
public sealed class DialogInfo<TDialog> : IEquatable<DialogInfo<TDialog>>
{
    public DialogInfo(TDialog dialog, DialogResult result)
    {
        Dialog = dialog;
        Result = result;
    }

    public TDialog Dialog { get; }
    public DialogResult Result { get; }

    public void Deconstruct(out TDialog dialog, out DialogResult result)
    {
        dialog = Dialog;
        result = Result;
    }

    public bool Equals(DialogInfo<TDialog>? other) =>
        other is not null && EqualityComparer<TDialog>.Default.Equals(Dialog, other.Dialog) && Result == other.Result;

    public override bool Equals(object? obj) => obj is DialogInfo<TDialog> other && Equals(other);

    public override int GetHashCode()
    {
        unchecked
        {
            return ((Dialog is null ? 0 : EqualityComparer<TDialog>.Default.GetHashCode(Dialog)) * 397) ^ (int)Result;
        }
    }
}
#endif
