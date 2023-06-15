using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    

    public class CustomList<T>
    {
        private readonly List<T> items;

        public CustomList()
        {
            items = new List<T>();
        }

        public T this[int index]
        {
            get {
                if (ValidateIndex(index))
                {
                    return items[index];
                }
                return default;

                
                 }
            set {
                if (ValidateIndex(index))
                {
                    items[index] = value;
                }
                else
                {
                    Console.WriteLine("Not a Valid index to insert anything");
                }
                 }
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void AddElement(T t)
        {
            items.Add(t);
        }

        public void AddList(List<T> list)
        {
            items.AddRange(list);
        }

        public bool InsertElement(T t, int index)
        {
            if (!ValidateIndex(index))
            {
                return false;
            }

            items.Insert(index, t);
            return true;
        }

        public bool InsertList(List<T> list, int index)
        {
            if (!ValidateIndex(index))
            {
                return false;
            }

            items.InsertRange(index, list);
            return true;
        }

        public T GetElement(int index, out bool isValid)
        {
            if (!ValidateIndex(index))
            {
                isValid = false;
                Console.WriteLine("No element found!");
                return default;
            }
            isValid = true;
            return items[index];
        }

        public List<T> GetList(int index, int count, out bool isValidRequest)
        {
            if (!ValidateIndex(index) || count <= 0 || index + count > items.Count)
            {
                isValidRequest = false;
                return default;
            }
            isValidRequest = true;
            return items.GetRange(index, count);
            
        }

        public void RemoveElement(T element)
        {
            if(items.Contains(element))
            {
                
                items.Remove(element);
                Console.WriteLine("Element Removed");
            }
            else
            {
                Console.WriteLine("No Elements to Remove");
            }
            
        }

        public void RemoveList(List<T> list)
        {
            
            foreach (var item in list)
            {
                items.Remove(item);
            }
        }

        public void Clear()
        {
            items.Clear();
        }

        
        public List<T> Find(Predicate<T> match)
        {
            List<T> matchingElements = items.FindAll(match);

            

            if (matchingElements != null && matchingElements.Count > 0)
            {
                Console.WriteLine("Found Elements:");
                foreach (var item in matchingElements)
                {
                    Console.WriteLine(item);
                }
            }
            return matchingElements;
        }
        private bool ValidateIndex(int i)
        {
            return i < items.Count && i >= 0;
        }
    }

}
