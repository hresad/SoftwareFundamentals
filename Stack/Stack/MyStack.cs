using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class MyStack<T>
    {
        private T[] array;
        private int currentIndex;
        public MyStack()
        {
            array = new T[3];
            currentIndex = -1;
        }
        private void Resize()
        {
            T[] newArray = new T[array.Length * 2];
            int i = 0;
            foreach (T item in array)
            {
                newArray[i++] = item;
            }
            array = newArray;
        }
        public void Push (T item)
        {
            currentIndex++;
            if (currentIndex == array.Length)
            {
                Resize();
            }
            array[currentIndex] = item;
        }
        public T Pop ()
        {
            if (currentIndex >= 0)
            {
                T item = array[currentIndex];
                currentIndex--;
                return item;
            } else
            {
                throw new IndexOutOfRangeException();
            }
            
        }
        public int Length()
        {
            return currentIndex + 1;
        }
    }
}
