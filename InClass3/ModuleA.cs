//CREATING CLASS/ OBJECTS

using System;

namespace InClass3B
{
    class Food
    {
        string cuisine = "Italian";
      

        static void Main(string[] args)
        {
            Food myObj1 = new Food();
            Food myObj2 = new Food();
            Console.WriteLine(myObj1.cuisine);
            Console.WriteLine(myObj2.cuisine);
        }
    }
}
