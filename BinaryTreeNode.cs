namespace BinaryTreeLab.Tree
{
  public class BinaryTreeNode<T>
  {
    public T Value { get; set; }
    public BinaryTreeNode<T>? Left { get; set; }
    public BinaryTreeNode<T>? Right { get; set; }
    public BinaryTreeNode<T>? Parent { get; set; }

    public BinaryTreeNode(T value)
    {
      Value = value;
    }
  }
}