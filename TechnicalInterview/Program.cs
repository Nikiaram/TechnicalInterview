using System.Xml.Linq;

namespace TechnicalInterview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static Node Reverse(Node node)
        {
            Node prev = node, next = null;
           
            while (prev != null)
            {
                Node temp = prev.next;
                prev.next = next;
                next = prev;
                prev = temp;    
            }

            node = next;

            return node;
        }
    }
}