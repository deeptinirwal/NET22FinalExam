using System;
using System.Collections.Generic;

namespace NET22FinalGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Generics");
            var numbers = new Generics<int>(3);
            Console.WriteLine("Value is : " + numbers.AddItems());
        }
    }

    public class Generics<T> where T : struct
    {
        private object _value;

        public Generics()
        {

        }
        public Generics(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T AddItems()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }


    }
}
