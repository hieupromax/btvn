using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvn
{
    public class MyStack<T>
    {
        private List<T> _items = new List<T>();

        public void Push(T item)
        {
            _items.Add(item);
        }
        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            T top = _items[_items.Count - 1];
            _items.RemoveAt(_items.Count - 1);
            return top;
        }
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            return _items[_items.Count - 1];
        }
        public bool IsEmpty()
        {
            return _items.Count == 0;
        }
    }

}