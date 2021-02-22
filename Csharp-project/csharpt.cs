using System;

namespace Csharpproject
{
    class Mathematics
    {
        public int f(int x)
        {
            return x * x;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int result = m.f(5);
            Console.WriteLine(result);
        }
        }
    }
