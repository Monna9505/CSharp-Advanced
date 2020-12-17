using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfIntegerEXERCISE
{
    public class Box<T>
    {
        public T SomeData { get; set; }
        public Box(T someData)
        {
            this.SomeData = someData;
        }
        public override string ToString()
        {
            return $"{SomeData.GetType()}: {this.SomeData}";
        }
    }
}
