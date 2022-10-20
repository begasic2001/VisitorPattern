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

            NumberCollection numberCollection = new NumberCollection();
           
            numberCollection.DisplayList();
            Console.WriteLine("--------------------------");
            IncrementNumberVisitor incrVisitor = new IncrementNumberVisitor();
            
            Console.WriteLine("IncrementNumberVisitor is about to visit the list: ");
           
            numberCollection.Accept(incrVisitor);
            Console.WriteLine("--------------------------");
            numberCollection.DisplayList();
            Console.ReadLine();
        }
    }
}
