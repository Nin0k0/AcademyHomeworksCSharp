using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Storage<T>
    {
        private readonly List<T> _list;

        public Storage()
        {
            _list = new List<T>();
        }

        public void AddItem(T t)
        {
            _list.Add(t);
        }

        public void RemoveItem(T t)
        {
            _list.Remove(t);
        }

        public void UpdateItem(T oldT, T newT)
        {
            int index = _list.IndexOf(oldT);
            if (index >= 0)
            {
                _list[index] = newT;
            }
        }


        //for testing
        public void PrintItems()
        {
            foreach (T t in _list)
            {
                Console.WriteLine(t);
            }
        }
    }
}
