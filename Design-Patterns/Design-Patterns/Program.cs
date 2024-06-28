using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using Design_Patterns.Structural_Design_Patterns.Facade_Design_Pattern;
using static Design_Patterns.Structural_Design_Patterns.Facade_Design_Pattern.Restaurant_Facade;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Facade Design Pattern.
            // =================================

            // 1. It provides a simplified and unified interface to a set of interfaces or subsystems 
            //    within a larger system, making it easier to use and reducing the complexity of the system
            //    for clients.

            // 2. Essentially, it acts as a facade or entry point to a more complex system, 
            //    shielding clients from its intricacies.

            // 3. This pattern involves a single wrapper class which contains a set of members which
            //    are required by client. These members access the system on behalf of the facade client
            //    and hide the implementaion details.
            
            
            // 4. Aggregate objects to simplify process.

            // Example : 1 ==> Using the Facade to start and stop the car.
             */
            Console.WriteLine("\n ==> Example: 1\n");
            CarFacade car = new CarFacade();

            // Simulate some driving.
            car.startCar();
            Console.WriteLine("\n---------------------\n");
            
            car.stopCar();

            // Example : 2 ==> Using the Facade for Client Order (Pizza/Bread).
            Console.WriteLine("\n ==> Example: 2");
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");

            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();

            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");

            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
            
           

            Console.ReadLine();
        }


    }
}
