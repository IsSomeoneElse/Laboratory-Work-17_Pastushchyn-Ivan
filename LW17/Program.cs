using System;
using System.Collections.Generic;

namespace LW17
{
    public abstract class Array
    {
        protected List<int> elements;

        public Array()
        {
            elements = new List<int>();
        }

        public virtual void Add(int element)
        {
            elements.Add(element);
        }

        public virtual void ProcessElements()
        {
            foreach (int element in elements)
            {
                Console.WriteLine(ProcessElement(element));
            }
        }

        protected abstract double ProcessElement(int element);
    }

    public class AndArray : Array
    {
        public override void Add(int element)
        {
            if (!elements.Contains(element))
            {
                elements.Add(element);
            }
        }

        protected override double ProcessElement(int element)
        {
            return Math.Sqrt(element);
        }
    }

    public class OnArray : Array
    {
        public override void Add(int element)
        {
            elements.Add(element);
        }

        protected override double ProcessElement(int element)
        {
            return Math.Log(element);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Array andArray = new AndArray();
            andArray.Add(2);
            andArray.Add(4);
            andArray.Add(2);
            andArray.Add(6);

            Console.WriteLine("AndArray elements:");
            andArray.ProcessElements();

            Console.WriteLine();

            Array onArray = new OnArray();
            onArray.Add(3);
            onArray.Add(5);
            onArray.Add(1);

            Console.WriteLine("OnArray elements:");
            onArray.ProcessElements();
        }
    }
}