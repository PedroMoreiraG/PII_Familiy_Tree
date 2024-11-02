using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el arbol genealogico
            var abuelo = new Node<Person>(new Person("Walter Rodríguez", 78));
            var padre1 = new Node<Person>(new Person("Gustavo Rodríguez", 52));
            var padre2 = new Node<Person>(new Person("Daniel Rodríguez", 46));
            var hijo1 = new Node<Person>(new Person("Nicolás Rodríguez", 24));
            var hijo2 = new Node<Person>(new Person("Patricia González", 48));
            var hijo3 = new Node<Person>(new Person("Fernanda Rodríguez", 20));

            // Lo construimos
            abuelo.AddChildren(padre1);
            abuelo.AddChildren(padre2);
            padre1.AddChildren(hijo1);
            padre1.AddChildren(hijo2);
            padre2.AddChildren(hijo3);
            
            
            //La suma de edades
            var sumVisitor = new SumVisitor();
            abuelo.Accept(sumVisitor);
            Console.WriteLine($"La suma de todas las edades es: {sumVisitor.Sum}");
            
            //El familiar con la edad mayor
            OldestChildrenVisitor oldestChildrenVisistor = new OldestChildrenVisitor();
            Console.WriteLine(oldestChildrenVisistor.getOldest(abuelo));
            
            //El familiar con el nombre mas largo
            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();
            Console.WriteLine(longestNameVisitor.getLongestName(abuelo));
        }
    }
}
