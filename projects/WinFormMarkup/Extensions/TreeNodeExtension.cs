namespace WinFormMarkup.Extensions;

/// <summary>
///     Fluent extensions for TreeNode.
/// </summary>
public static class TreeNodeExtension
{
    /// <summary>
    ///     Appends the supplied tree nodes and returns the same instance.
    /// </summary>
    /// <param name="treeNode">The instance to configure.</param>
    /// <param name="nodes">The nodes to add.</param>
    /// <typeparam name="TTreeNode">The concrete type of the instance.</typeparam>
    /// <returns>The same <paramref name="treeNode" /> instance for fluent composition.</returns>
    public static TTreeNode Nodes<TTreeNode>(this TTreeNode treeNode, params TreeNode[] nodes)
        where TTreeNode : TreeNode
    {
        treeNode.Nodes.AddRange(nodes);
        return treeNode;
    }
}