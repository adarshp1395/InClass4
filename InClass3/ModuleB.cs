//CLASS MEMBERS

using System;
namespace InClass3B
{
    class Vehicle
    {
        string type;
        string size;
        int wheel;

        static void Main(string[] args)
        {
            Vehicle I = new Vehicle();
            I.type = "Trailer";
            I.size = "CHuge";
            I.wheel = 18;

            Vehicle M = new Vehicle();
            M.type = "Car";
            M.size = "Compact";
            M.wheel = 4;

            Console.WriteLine(I.type);
            Console.WriteLine(I.type);
        }
    }
}
