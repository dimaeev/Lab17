using BinaryTreeLab.Tree;

namespace BinaryTreeLab.Iterators
{
  public class BinaryTreeIterator<T>
  {
    private BinaryTreeNode<T>? _current;

    public BinaryTreeIterator(BinaryTreeNode<T>? root)
    {
      _current = root;
      while (_current?.Left != null)
        _current = _current.Left;
    }

    public bool HasNext()
    {
      return _current != null;
    }

    public BinaryTreeNode<T> Next()
    {
      var result = _current!;

      if (_current!.Right != null)
      {
        _current = _current.Right;
        while (_current!.Left != null)
          _current = _current.Left;
      }
      else
      {
        while (_current!.Parent != null && _current == _current.Parent.Right)
        {
          _current = _current.Parent;
        }
        _current = _current.Parent;
      }

      return result;
    }
  }
}