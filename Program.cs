// See https://aka.ms/new-console-template for more information
using BinaryTree.Model;

Console.WriteLine("Start!");
BinaryTree.Class.BinaryTree binaryTree = new BinaryTree.Class.BinaryTree();

int[] input = { 1, 2, 7, 3, 10, 5, 8 };
var output = String.Empty;
foreach (var itm in input)
{   
    output += "," + itm;
}
Console.WriteLine("Input :" + output);
foreach (var itm in input)
{
    binaryTree.Add(itm);
}

Node node = binaryTree.Find(5);
int depth = binaryTree.GetTreeDepth();

Console.WriteLine("PreOrder Traversal:");
binaryTree.TraversePreOrder(binaryTree.Root);
Console.WriteLine();

Console.WriteLine("InOrder Traversal:");
binaryTree.TraverseInOrder(binaryTree.Root);
Console.WriteLine();

Console.WriteLine("PostOrder Traversal:");
binaryTree.TraversePostOrder(binaryTree.Root);
Console.WriteLine();