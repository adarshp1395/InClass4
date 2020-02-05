//POLYMORPHISM

using System;
namespace InClass3G
{
        class Restaurant  // Base class (parent) 
        {
            public virtual void RestaurantFood()
            {
                Console.WriteLine("The Restaurant has different tastes");
            }
        }

        class Soup : Restaurant  // Derived class (child) 
        {
            public override void RestaurantFood()
            {
                Console.WriteLine("The Soup tastes peppery");
            }
        }

        class Salad : Restaurant  // Derived class (child) 
        {
            public override void RestaurantFood()
            {
                Console.WriteLine("The Salad says tastes bland");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Restaurant myRestaurant = new Restaurant();  // Create a Restaurant object
                Restaurant mySoup = new Soup();  // Create a Soup object
                Restaurant mySalad = new Salad();  // Create a Salad object

                myRestaurant.RestaurantFood();
                mySoup.RestaurantFood();
                mySalad.RestaurantFood();
            }
        }
  
}
