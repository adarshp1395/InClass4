//INHERITANCE

using System;
namespace InClass3F
{
    class Menu  // base class (parent) 
    {
        public string Soup = "Broccoli Cheddar";  // Menu field
        public void taste()             // Menu method 
        {
            Console.WriteLine("Its hot!");
        }
    }

    class Restaurant : Menu  // derived class (child)
    {
        public string modelName = "Mustang";  // Restaurant field
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a myRestaurant object
            Restaurant myRestaurant = new Restaurant();

            // Call the taste() method (From the Menu class) on the myRestaurant object
            myRestaurant.taste();

            // Display the value of the Soup field (from the Menu class) and the value of the modelName from the Restaurant class
            Console.WriteLine(myRestaurant.Soup + " " + myRestaurant.modelName);
        }
    }
}
