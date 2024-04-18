using BinaryTree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Interface
{
    public interface IBinaryTree
    {
        public bool Add(int value);
        public Node Find(int value);
        public void Remove(int value);
        public Node Remove(Node parent, int key);
        public int MinValue(Node node);

        public Node Find(int value, Node parent);
        public int GetTreeDepth();
        public int GetTreeDepth(Node parent);

        public void TraversePreOrder(Node parent);
        public void TraversePostOrder(Node parent);

        public void TraverseInOrder(Node parent);


    }
}
