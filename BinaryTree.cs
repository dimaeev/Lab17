namespace BinaryTreeLab.Tree
{
  public class BinaryTree<T> where T : IComparable<T>
  {
    public BinaryTreeNode<T>? root { get; private set; }

    public void Insert(T value)
    {
      if (root == null)
      {
        root = new BinaryTreeNode<T>(value);
      }
      else
      {
        Insert(root, value);
      }
    }

    private void Insert(BinaryTreeNode<T> node, T value)
    {
      if (value.CompareTo(node.Value) < 0)
      {
        if (node.Left == null)
        {
          node.Left = new BinaryTreeNode<T>(value) { Parent = node };
        }
        else
        {
          Insert(node.Left, value);
        }
      }
      else
      {
        if (node.Right == null)
        {
          node.Right = new BinaryTreeNode<T>(value) { Parent = node };
        }
        else
        {
          Insert(node.Right, value);
        }
      }
    }
  }
}