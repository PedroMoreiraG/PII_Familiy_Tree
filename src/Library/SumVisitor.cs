namespace Library
{
    public class SumVisitor : IVisitor<Person>
    {
        private int sum = 0;

        public int Sum
        {
            get { return this.sum; }
        }

        public void Visit(Node<Person> node) 
        {
            this.sum += node.Data.Age;
            foreach (Node<Person> item in node.Children)
            {
                item.Accept(this);
            }
        }
        
        public int getAgeSum(Node<Person> FirstNode) {
            FirstNode.Accept(this);
            return this.sum;
        }
    }
}
