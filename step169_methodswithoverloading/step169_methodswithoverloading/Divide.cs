using System;
using System.Collections.Generic;
using System.Text;

namespace step169_methodswithoverloading
{
    class Divide
    {
        public int Operation(int x)
        {
            return x / 2;
        }
        public void Operation(int x, out int result)
        {
            result = x / 2;
        }
    }

    public static class MyStaticClass
    {
        public static string desc = "Hello, I am a static class.";

        public static string Desc { get => desc; set => desc = value; }
    }
}

