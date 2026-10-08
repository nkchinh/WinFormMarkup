namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for TreeView.
/// </summary>
public static class TreeViewExtension
{
    /// <summary>
    ///     Appends the supplied tree nodes and returns the same instance.
    /// </summary>
    /// <param name="treeView">The instance to configure.</param>
    /// <param name="nodes">The nodes to add.</param>
    /// <typeparam name="TTreeView">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="treeView" /> instance for fluent composition.</returns>
    public static TTreeView Nodes<TTreeView>(this TTreeView treeView, params TreeNode[] nodes)
        where TTreeView : TreeView
    {
        treeView.Nodes.AddRange(nodes);
        return treeView;
    }

    /// <summary>
    ///     Subscribes the action to the AfterSelect event and returns the same instance.
    /// </summary>
    /// <param name="treeView">The instance to configure.</param>
    /// <param name="action">The action invoked with the selected tree node.</param>
    /// <typeparam name="TTreeView">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="treeView" /> instance for fluent composition.</returns>
    public static TTreeView OnAfterSelect<TTreeView>(this TTreeView treeView, Action<TreeNode> action)
        where TTreeView : TreeView
    {
        treeView.AfterSelect += (sender, e) => action(e.Node);
        return treeView;
    }
}