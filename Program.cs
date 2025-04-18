using BinaryTreeLab.Tree;
using BinaryTreeLab.Iterators;

namespace BinaryTreeLab
{
  class Program
  {
    static void Main(string[] args)
    {
      var tree = new BinaryTree<int>();
      tree.Insert(5);
      tree.Insert(3);
      tree.Insert(7);
      tree.Insert(2);
      tree.Insert(4);
      tree.Insert(6);
      tree.Insert(8);

      Console.WriteLine("Прямой обход дерева (Next):");
      var iterator = new BinaryTreeIterator<int>(tree.Root);
      while (iterator.HasNext())
      {
        Console.WriteLine(iterator.Next().Value);
      }

      Console.WriteLine("\nЦентральный обход (лямбда):");
      var lambdaResult = LambdaIterator.InOrder(tree.Root);
      foreach (var node in lambdaResult)
      {
        Console.WriteLine(node.Value);
      }
    }
  }
}