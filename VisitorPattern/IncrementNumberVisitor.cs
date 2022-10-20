using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class IncrementNumberVisitor : IVisitor
    {
        public void VisitSmallNumbers(SmallNumber number)
        {
            Number currentNumber = number;
          
            int temp = currentNumber.NumberValue;
           
            Console.WriteLine($"{currentNumber.TypeInfo} is {currentNumber.NumberValue}; I use it as:{++temp} for rest of my code.");
            //Remaining code, if any
        }
        public void VisitBigNumbers(BigNumber number)
        {
            Number currentNumber = number;
         
            int temp = currentNumber.NumberValue;
            
            Console.WriteLine($"{currentNumber.TypeInfo} is {currentNumber.NumberValue}; I convert it as:{temp + 10} for rest of my code.");
            
        }
    }
}
