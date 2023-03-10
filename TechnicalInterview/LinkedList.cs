using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalInterview
{
    public class LinkedList
    {
        public Node head { get; set; }
        public void Print()
        {
            Node current = head;

            if (current != null )
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }    
    }
}
