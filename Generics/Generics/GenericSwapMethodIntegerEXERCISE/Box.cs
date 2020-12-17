using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegerEXERCISE
{
    public class Box<T>
    {
        private T someData;
        public Box(T someData)
        {
            this.someData = someData;
        }
        public override string ToString()
        {
            return $"{this.someData.GetType()}: {this.someData}";
        }
    }
}
