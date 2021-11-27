using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Tree<T>
    {
        public readonly TreeNode<T> _root;
        public readonly Hirerarchy _hierarchy;
        public Tree(Hirerarchy hire)
        {
            _hierarchy = hire;
            _root = new TreeNode<T>(this);
        }
        public void Destroy()
        {

        }
        //protected virtual void OnDrawTreeNode(TreeNode<T> node)
        //{
        //    if (node.IsLeaf)
        //    {
        //        return;
        //    }
        //    // do something? maybe later overload this method with a delegate
        //}
    }
}
