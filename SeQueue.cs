using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeQ
{

    public class SeQueue<T>
    {

        private readonly List<T> _list;


        public SeQueue(List<T> list)
        {
            if (list == null)
            {
                throw new ArgumentException();
            }
            _list = list;
        }

        public SeQueue()
            : this(new List<T>())
        {

        }

        public void Enqueue(T value)
        {
            if (value == null)
            {
                throw new ArgumentException();
            }

            _list.Add(value);
        }

        public T Dequeue()
        {

            if (IsEmpty())
            {
                throw new ArgumentException();
            }
            var item = default(T);
            item = _list[0];
            _list.RemoveAt(0);
            Console.WriteLine(item);
            return (item);
        }


        public T PeekQueue()
        {
            T item = default(T);

            item = _list[0];

            if (item == null)
            {
                throw new ArgumentException();
            }
            Console.WriteLine(item);
            return item;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public int Size()
        {
            return _list.Count;
        }

        public bool IsEmpty()
        {
            return _list == null;
        }

        public void PrintElements()
        {
            foreach (var value in _list)
            {
                Console.WriteLine(value);
            }
        }
    }
 }


