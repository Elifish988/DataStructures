using Day_1;
using System;

class Program
{
    static void Main(string[] args)
    {
        BinaryTree binnaryTree = new BinaryTree();
        binnaryTree.Insert(2);
        binnaryTree.Insert(-1);
        binnaryTree.Insert(3);
        Console.WriteLine(binnaryTree.Find(2));
        Console.WriteLine(binnaryTree.Find(1));
        Console.WriteLine(binnaryTree.Find(3));
        Console.WriteLine(binnaryTree.GetMin());


    }
}




