using System;
namespace ArrayElements
{
    class program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 10, 4, 8, 9 };
            float[] floatArr = { 2.33f, 5.33f, 4.55f, 6.88f, 7.88f };
            Array array = new Array();
            Console.WriteLine("\n--------It is Integer type value in array------\n");
            array.Toprint(intArr);
            Console.WriteLine("\n--------It is Float type value in array------\n");
            array.Toprint(floatArr);
        }
    }
}