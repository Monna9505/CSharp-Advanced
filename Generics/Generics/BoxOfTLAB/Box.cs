using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> box;
        public int Count
        {
            get
            {
                return box.Count;
            }
        }
        public Box()
        {
            this.box = new Stack<T>();
        }
        public void Add(T element)
        {
            this.box.Push(element);
        }
        public T Remove()
        {
            return this.box.Pop();
        }
    }
}
