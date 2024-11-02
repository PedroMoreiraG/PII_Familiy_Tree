namespace Library;

public class LongestNameVisitor : IVisitor<Person>
{
    private int Length = 0;
    private string Name;
    
    public void Visit(Node<Person> node) 
    {
        if (node.Data.Name.Length > Length)
        {
            this.Length = node.Data.Name.Length;
            this.Name = node.Data.Name;
        }
        foreach (Node<Person> item in node.Children)
        {
            item.Accept(this);
        }
    }

    public string getLongestName(Node<Person> FirstNode) 
    {
        FirstNode.Accept(this);
        return this.Name;
    }
}