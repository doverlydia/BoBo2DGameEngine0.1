using System;
using System.Collections.Generic;

namespace BoBo2DGameEngine
{
    public class TreeNode<T>
    {
        public delegate bool TraversalDataDelegate(T data);
        public delegate bool TraversalNodeDelegate(TreeNode<T> node);

        protected TreeNode<T> _parent;
        protected int _level;

        protected readonly T _data;
        protected readonly List<TreeNode<T>> _children;

        public readonly Tree<T> _tree;

        public TreeNode(Tree<T> tree)
        {
            _tree = tree;
            _data = default;
        }

        public TreeNode(T data, Tree<T> tree) : this(tree)
        {
            _data = data;
            _children = new List<TreeNode<T>>();
            _level = 0;
        }

        public TreeNode(T data, TreeNode<T> parent, Tree<T> tree) : this(data, tree)
        {
            _parent = parent;
            _level = _parent != null ? _parent.Level + 1 : 0;
        }

        public int Level { get { return _level; } }
        public int Count { get { return _children.Count; } }
        public bool IsRoot { get { return _parent == null; } }
        public bool IsLeaf { get { return _children.Count == 0; } }
        public T Data { get { return _data; } }
        public TreeNode<T> Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent?.RemoveChild(this);
                _parent = value;
                _parent._children.Add(this);
                _level = _parent != null ? _parent.Level + 1 : 0;
            }
        }

        public TreeNode<T> this[int key]
        {
            get { return _children[key]; }
        }

        public void Clear()
        {
            _children.Clear();
        }

        public TreeNode<T> AddChild(T value)
        {
            TreeNode<T> node = new(value, this, _tree);
            _children.Add(node);

            return node;
        }

        public TreeNode<T> AddChild()
        {
            return AddChild(default);
        }

        public bool HasChild(T data)
        {
            return FindInChildren(data) != null;
        }

        public TreeNode<T> FindInChildren(T data)
        {
            int i = 0, l = Count;
            for (; i < l; ++i)
            {
                TreeNode<T> child = _children[i];
                if (child.Data.Equals(data)) return child;
            }

            return null;
        }

        public bool RemoveChild(TreeNode<T> node)
        {
            node._parent = null;
            return _children.Remove(node);
        }

        public void Traverse(TraversalDataDelegate handler)
        {
            if (handler(_data))
            {
                int i = 0, l = Count;
                for (; i < l; ++i) _children[i].Traverse(handler);
            }
        }

        public void Traverse(TraversalNodeDelegate handler)
        {
            if (handler(this))
            {
                int i = 0, l = Count;
                for (; i < l; ++i) _children[i].Traverse(handler);
            }
        }

    }
}
