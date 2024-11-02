namespace Library;

public class OldestChildrenVisitor: IVisitor<Person>
{
    private int Oldest = 0;
    
    public void Visit(Node<Person> node) {
        if (node.Data.Age > Oldest)
        {
            this.Oldest = node.Data.Age;
        }
        foreach (Node<Person> item in node.Children)
        {
            item.Accept(this);
        }
    }

    public int getOldest(Node<Person> FirstNode) 
    {
        FirstNode.Accept(this);
        return this.Oldest;
    }
}