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
            Number currentNumber = number as Number;
            /*
            I do not want( infact I can't change because it's readonly 
           now) to modify the original data. So, I'm making a copy of it 
           before I use it.
            */
            int temp = currentNumber.NumberValue;
            //For SmallNumber's incrementing by 1
            Console.WriteLine($"{currentNumber.TypeInfo} is {currentNumber.NumberValue}; I use it as:{++temp} for rest of my code.");
            //Remaining code, if any
        }
        public void VisitBigNumbers(BigNumber number)
        {
            Number currentNumber = number as Number;
            /*
            I do not want( infact I can't change because it's readonly 
           now) to modify the original data. So, I'm making a copy of it 
           before I use it.
            */
          
        int temp = currentNumber.NumberValue;
            //For BigNumber's incrementing by 10
            Console.WriteLine($"{currentNumber.TypeInfo} is {currentNumber.NumberValue}; I convert it as:{temp + 10} for rest of my code.");
            //Remaining code, if any
        }
    }
}
