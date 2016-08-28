using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace GenericList
{
    public class GenericListClass<T> : IEnumerable
    {

        public T[] genericArray;
        public int _count;

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
                Console.Write(genericArray[i] + ", ");

            }
        }

        public int Count
        {
            get
            {
                return genericArray.Length;
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < genericArray.Length; i++)
            {
                yield return genericArray[i];
            }

        }

        public override String ToString()
        {
            string newString = "";
            foreach (T item in genericArray)
            {
                newString += item.ToString();
            }
            return newString;
        }


        public static GenericListClass<T> operator +(GenericListClass<T> item1, GenericListClass<T> item2)
        {
            int x = item1.Count;
            int y = item2.Count;
            GenericListClass<T> newCombinedList = new GenericListClass<T>(new T[] { });
            foreach (T item in item1)
            {
                newCombinedList.Add(item);
            }
            foreach (T item in item2)
            {
                newCombinedList.Add(item);
            }
            return newCombinedList;

        }

        public static GenericListClass<T> operator -(GenericListClass<T> item1, GenericListClass<T> item2)
        {
            foreach (T stuff in item2)
            {
                foreach (T thing in item1)
                {
                    if (stuff.Equals(thing))
                    {
                        item1.Remove(stuff);
                    }
                }

            }
            return item1;
        }




        public GenericListClass<T> Zip(GenericListClass<T> item)
        {
            T[] genericArray2 = item.genericArray;
            int x = genericArray.Length;
            int y = genericArray2.Length;
            int z = 0;
            if (x > y)
            {

                z = y;
            }
            else
            {
                z = x;
            }
            GenericListClass<T> ZipperedList = new GenericListClass<T>(new T[] { });
            for (int i = 0; i < z; i++)
            {
                ZipperedList.Add(genericArray[i]);
                ZipperedList.Add(genericArray2[i]);
            }
            return ZipperedList;
        }

        public void Sort()
        {
            Array.Sort(genericArray);
        }



    }
}


    


