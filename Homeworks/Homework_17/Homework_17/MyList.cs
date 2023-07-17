using System.Collections;

namespace Homework_17
{

    public class MyList<T> : IEnumerable<T>
    {
        private T[] array;
        private int count;

        public MyList()
        {
            array = new T[0];
            count = 0;
        }

        public void Add(T item)
        {
            Array.Resize(ref array, count + 1);
            array[count] = item;
            count++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            int index = Array.IndexOf(array, item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }

            return false;
        }

        public void RemoveRange(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Remove(item);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            Array.Copy(array, index + 1, array, index, count - index - 1);
            count--;
            Array.Resize(ref array, count);
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                return array[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                array[index] = value;
            }
        }

        public int Count => count;

        public bool Contains(T item)
        {
            return Array.IndexOf(array, item) > -1;
        }

        public T Single(Func<T, bool> predicate)
        {
            T result = default(T);
            bool found = false;

            foreach (T item in array)
            {
                if (predicate(item))
                {
                    
                    result = item;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                throw new InvalidOperationException("No matching element!");
            }

            return result;
        }

        public T? SingleOrDefault(Func<T, bool> predicate)
        {
            T result = default(T);
            bool found = false;

            foreach (T item in array)
            {
                if (predicate(item))
                {

                    result = item;
                    found = true;
                    break;
                }
            }

            return result;
        }

        public T? Find(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            foreach (T item in array)
            {
                if (match(item))
                {
                    return item;
                }
            }

            return default(T);
        }

        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            foreach (T item in array)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }


        //public bool HasDefault(T item)
        //{
        //    EqualityComparer<T> comparer = EqualityComparer<T>.Default;
        //    T defaultValue = default(T);

        //    if (comparer.Equals(item,defaultValue))
        //    {
        //        return true;
        //    }

        //    return false;
        //}
    }
}
