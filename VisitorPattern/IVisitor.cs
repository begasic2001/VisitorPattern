using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IVisitor
    {
        //A visit operation for SmallNumber class
        void VisitSmallNumbers(SmallNumber number);
        //A visit operation for BigNumber class
        void VisitBigNumbers(BigNumber number);
    }
}
