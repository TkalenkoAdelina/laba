﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class A
    {
        public decimal a;
        public decimal b;
        public A()
        {

            a = 4;

            b = 6;
        }
        public A(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }
        public decimal c
        {
            get
            {
                if (a > b) return a;
                else return b;
            }
        }
    }
    class B : A
    {
        public B(decimal a, decimal b) : base(a, b)
        {
        }
        public B()
        {

            d = 7;
        }
        public decimal v;
        public decimal d;
        public decimal c2
        {
            get { return v = --a + (++b) + d; }
            set { v = value; }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            Console.WriteLine("Значение с = {0}", obj.c);
            B obj1 = new B();
            Console.WriteLine("Значение с2={0}", obj1.c2);
            Console.ReadKey();
        }
    }
}
