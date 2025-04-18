using System.Collections.Generic;

namespace BinaryTreeLab.Tree
{
  public static class LambdaIterator
  {
    public static IEnumerable<BinaryTreeNode<T>> InOrder<T>(BinaryTreeNode<T>? root)
    {
      var result = new List<BinaryTreeNode<T>>();
      InOrderTraversal(root, result);
      return result;
    }

    private static void InOrderTraversal<T>(BinaryTreeNode<T>? node, List<BinaryTreeNode<T>> result)
    {
      if (node == null) return;

      InOrderTraversal(node.Left, result);
      result.Add(node);
      InOrderTraversal(node.Right, result);
    }
  }
}