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
        private int remove;
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
        //constructor
        public CustomList()
        {
            items = new T[4];
            count = 0;
            capacity = 4;
        }

        //member methods

        public void Add(T item)
        {
            items[count] = item;
            count++;
        }
    }
}
