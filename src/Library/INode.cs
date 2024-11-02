namespace Library;

public interface INode<T>
{
    void Accept(IVisitor<T> visitor);
}