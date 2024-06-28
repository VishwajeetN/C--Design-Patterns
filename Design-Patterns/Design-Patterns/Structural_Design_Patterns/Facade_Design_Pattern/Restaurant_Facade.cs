using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Design_Patterns.Facade_Design_Pattern
{
    internal class Restaurant_Facade
    {
        // Subsytem Interface - 1
        public interface IPizza
        {
            void GetVegPizza();
            void GetNonVegPizza();
        }

        // Subsytem Interface - 2
        public interface IBread
        {
            void GetGarlicBread();
            void GetCheesyGarlicBread();
        }

        // Subsystem 1
        public class PizzaProvider : IPizza
        {
            public void GetNonVegPizza()
            {
                GetNonVegToppings();
                Console.WriteLine("Getting Non Veg Pizza.");
            }

            public void GetVegPizza()
            {
                Console.WriteLine("Getting Veg Pizza.");
            }

            private void GetNonVegToppings()
            {
                Console.WriteLine("Getting Non Veg Pizza Toppings.");
            }
        }

        // Subsystem 2

        public class BreadProvider : IBread
        {
            public void GetGarlicBread()
            {
                Console.WriteLine("Getting Garlic Bread.");
            }

            public void GetCheesyGarlicBread()
            {
                GetCheese();
                Console.WriteLine("Getting Cheesy Garlic Bread.");
            }

            private void GetCheese()
            {
                Console.WriteLine("Getting Cheese.");
            }
        }


        // Facade

        public class RestaurantFacade
        {
            private IPizza _PizzaProvider;
            private IBread _BreadProvider;

            public RestaurantFacade()
            {
                _PizzaProvider = new PizzaProvider();
                _BreadProvider = new BreadProvider();
            }

            public void GetNonVegPizza()
            {
                _PizzaProvider.GetNonVegPizza();
            }

            public void GetVegPizza()
            {
                _PizzaProvider.GetVegPizza();
            }

            public void GetGarlicBread()
            {
                _BreadProvider.GetGarlicBread();
            }

            public void GetCheesyGarlicBread()
            {
                _BreadProvider.GetCheesyGarlicBread();
            }
        }
    }
}
