using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class TreeNode : IEnumerable<TreeNode>
    {
        protected TreeNode _parent;
        protected int _level;

        public readonly List<TreeNode> _children;

        public TreeNode()
        {
            _children = new List<TreeNode>();
            _level = 0;
        }

        public TreeNode(TreeNode parent)
        {
            _parent = parent;
            _level = _parent != null ? _parent.Level + 1 : 0;
        }

        public int Level { get { return _level; } }
        public int Count { get { return _children.Count; } }
        public bool IsRoot { get { return _parent == null; } }
        public bool IsLeaf { get { return _children.Count == 0; } }
        public TreeNode Parent
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

        public TreeNode this[int key]
        {
            get { return _children[key]; }
        }

        public void Clear()
        {
            foreach (var item in _children)
            {
                item.Parent = null;
            }
            _children.Clear();
        }

        public TreeNode AddChild(TreeNode node)
        {
            _children.Add(node);

            return node;
        }

        public bool HasChild(TreeNode node)
        {
            return FindInChildren(node) != null;
        }

        public TreeNode FindInChildren(TreeNode node)
        {
            int i = 0, l = Count;
            for (; i < l; ++i)
            {
                TreeNode child = _children[i];
                if (child.Equals(node)) return child;
            }

            return null;
        }
        public bool RemoveChild(TreeNode node)
        {
            node._parent = null;
            return _children.Remove(node);
        }
        public IEnumerable<T> GetChildren<TreeNode>() where TreeNode : T => _children.OfType<T>();
        public T GetChild<TreeNode>() where TreeNode : T => GetChildren<T>().FirstOrDefault();

        public IEnumerator<TreeNode> GetEnumerator()
        {
            return ((IEnumerable<TreeNode>)_children).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_children).GetEnumerator();
        }
    }
}
