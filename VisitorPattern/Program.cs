using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Visitor Pattern Demo***\n");
            NumberCollection numberCollection = new NumberCollection();
            //Showing the current list
            numberCollection.DisplayList();
            IncrementNumberVisitor incrVisitor = new
           IncrementNumberVisitor();
            //Visitor is visiting the list
            Console.WriteLine("IncrementNumberVisitor is about to visit the list: ");
           
            numberCollection.Accept(incrVisitor);
            //Showing the current list
            numberCollection.DisplayList();
            Console.ReadLine();
        }
    }
}
