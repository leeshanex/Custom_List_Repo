using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Proj
{
    public class CustomList<T>
    {
        //member variables
        private T[] items;
        private int count;
        private int capacity;
        //properties
        public T this[int index]
        {
            get
            {
                if(index < count && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                items[index] = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        
        //constructor
        public CustomList()
        {
            count = 0;
            capacity = 4; 
            items = new T[capacity];
        }

        //member methods

        public void Add(T item)
        {

            if (count == capacity && count > capacity)
            {
                capacity *= 2;
                T[] tempArray = new T[capacity];

                for(int i = 0; i < count; i++)
                {
                    items[i] = tempArray[i];
                }
            }
            items[count] = item;
            count++;

        }
        public void Remove(T item)
        {
            
            if (count < 0)
            {
                count--;
            }
            
        }
    }
}
