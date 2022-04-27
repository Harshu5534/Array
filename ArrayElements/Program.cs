using System;
namespace ArrayElements
{
    class program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 10, 4, 8, 9 };
            Array array = new Array();
            Console.WriteLine("--------It is Integer type value in array------");
            array.Toprint(intArr);
        }
    }
}