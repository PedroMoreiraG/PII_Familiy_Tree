namespace Library
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Node<T>: INode<T>
    {
        private T data;
        private List<Node<T>> children = new List<Node<T>>();

        public T Data
        {
            get { return this.data; }
        }

        public ReadOnlyCollection<Node<T>> Children
        {
            get { return this.children.AsReadOnly(); }
        }

        public Node(T data)
        {
            this.data = data;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }

        public void Accept(IVisitor<T> visitor)
        {
            visitor.Visit(this);
        }
    }
}
