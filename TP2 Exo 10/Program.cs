using System;
using System.Collections.Generic;
using static TP2_Exo_10.Program;

namespace TP2_Exo_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            

        }
        public static int SumList(List<int> nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }

        public class Pile<T>
        {
            private List<T> pile;

            public Pile()
            {
                pile = new List<T>();
            }

            public void Push(T element)
            {
                pile.Add(element);
            }

            public T Pop()
            {
                if (pile.Count == 0)
                {
                    throw new InvalidOperationException("La pile est vide");
                }

                T element = pile[pile.Count - 1];
                pile.RemoveAt(pile.Count - 1);
                return element;
            }
            public int Count()
            {
                return pile.Count;
            }
        }


        public class File<T>
        {
            private List<T> elements;

            public File()
            {
                this.elements = new List<T>();
            }

            public void Enqueue(T element)
            {
                this.elements.Add(element);
            }
            public T Dequeue()
            {
                if (this.elements.Count == 0)
                    throw new InvalidOperationException("La file est vide");

                T element = this.elements[0];
                this.elements.RemoveAt(0);
                return element;
            }
            public int Count()
            {
                return elements.Count;
            }
        }

        public class Dictionnaire<TKey, TValue>
        {
            private Dictionary<TKey, TValue> dictionnaire = new Dictionary<TKey, TValue>();

            public void Add(TKey key, TValue value)
            {
                dictionnaire.Add(key, value);
            }

            public TValue GetValue(TKey key)
            {
                return dictionnaire[key];
            }

            public int Count()
            {
                return dictionnaire.Count;
            }
        }
    }
}