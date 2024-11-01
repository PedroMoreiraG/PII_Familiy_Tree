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
            sum += node.Data.Age;
        }
    }
}
