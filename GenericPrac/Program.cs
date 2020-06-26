using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrac
{
    class Wanted<T>
    {
        public T Value;
        public Wanted(T value)
        {
            this.Value = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("Greeting");
            Wanted<int> wantedInt = new Wanted<int>(100);
            Wanted<double> wantedDouble = new Wanted<double>(3.14);
            Console.WriteLine("String" + wantedString.Value);
            Console.WriteLine("정수" + wantedInt.Value);
            Console.WriteLine("실수" + wantedDouble.Value);


        }
    }
}
