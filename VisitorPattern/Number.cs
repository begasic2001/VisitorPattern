using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public abstract class Number
    {
        private int numberValue;
        private string type;
        public Number(string type, int number)
        {
            this.type = type;
            this.numberValue = number;
        }
        
        public int NumberValue
        {
            get
            {
                return numberValue;
            }
        }
        public string TypeInfo
        {
            get
            {
                return type;
            }
        }
        //public abstract void SomeMethod();
        public abstract void Accept(IVisitor visitor);
    
    }
}
