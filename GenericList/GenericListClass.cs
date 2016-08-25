using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericListClass<T> : IEnumerable, IFormattable
    {

        public T[] genericArray;
        int position = 0;

        public GenericListClass(T[] item)
        {
            genericArray = item;
        }

        public Array Add(T item)
        {
            T[] newGenericArray = new T[genericArray.Length + 1];
            if (genericArray.Length == 0)
            {
                newGenericArray = new T[1] { item };
            }
            else
            {
                int j = genericArray.Length;

                for (int i = 0; i < j; i++)
                {
                    newGenericArray[i] = genericArray[i];
                }
                newGenericArray[j] = item;
                Console.WriteLine(newGenericArray[j]);
            }
            genericArray = newGenericArray;
            return genericArray;

        }


        public Array Remove(T item)
        {
            int k = 0;
            for (int i = 0; i < genericArray.Length; i++)

            {
                if (genericArray[i].Equals(item))
                {
                    k++;
                }

            }
            T[] newGenericArray = new T[genericArray.Length - k];

            int j = 0;
            for (int i = 0; i < genericArray.Length; i++)
            {

                if (genericArray[i].Equals(item))
                {

                }
                else
                {
                    newGenericArray[j] = genericArray[i];
                    j++;
                }
            }
            genericArray = newGenericArray;
            return genericArray;
        }

        public void PrintList()
        {
            for (int i = 0; i < genericArray.Length; i++)
            {
                Console.WriteLine(genericArray[i]);

            }
        }
        public int Count()
        {
            int j = genericArray.Length;
            return j;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < genericArray.Length; i++)
            {
                yield return genericArray[i];
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        public override String ToString()
        {
                return ToString("G");
        }

        public void PrintString()
        {
            foreach (T item in genericArray)
            {
                Console.Write(item.ToString());
            }
        }

        private string ToString(string v)
        {
            throw new NotImplementedException();
        }





       
    }
}


