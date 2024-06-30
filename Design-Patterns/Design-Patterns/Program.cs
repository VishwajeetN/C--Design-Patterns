using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;

// Facade Design Pattern Namespace
using Design_Patterns.Structural_Design_Patterns.Facade_Design_Pattern;
using static Design_Patterns.Structural_Design_Patterns.Facade_Design_Pattern.Restaurant_Facade;
using static Design_Patterns.Structural_Design_Patterns.Facade_Design_Pattern.Ecommerce_Facade;

// Command Design Pattern Namespace

using Design_Patterns.Behavioral_Design_Patterns.Command_Pattern;
using static Design_Patterns.Behavioral_Design_Patterns.Command_Pattern.Command;


// Adapter Design Pattern Namespace
using static Design_Patterns.Structural_Design_Patterns.Adapter_Design_Pattern.Adapter_Pattern;
using static Design_Patterns.Structural_Design_Patterns.Adapter_Design_Pattern.Adapter_Pattern2;

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
            //    shielding clients from its intricaciesc(Complexcity).

            // 3. This pattern involves a single wrapper class which contains a set of members which
            //    are required by client. These members access the system on behalf of the facade client
            //    and hide the implementaion details.
            
            
            // 4. Aggregate objects to simplify process.

            // Example : 1 ==> Using the Facade to start and stop the car.
             
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
            


            // Example : 3 ==> Using the Facade for Ecommerce Order Product.

            OrderFacade order = new OrderFacade();
            order.PlaceOrder();
             */

            //// =================================================================================================================================================
            /*
            // Command Design Pattern

            // Create the Receiver Object.
            Console.WriteLine("\n---------------Windows File System Operation------------------------------\n");
            IFileSystemReceiver fsWindows = new WindowsFileSystemReceiver();

            // Define
            FileInvoker windowsFileInvoker;

            // Create command and associate with Receiver.
            OpenFileCommand WindowOpenFileCommand = new OpenFileCommand(fsWindows);
            windowsFileInvoker = new FileInvoker(WindowOpenFileCommand);
            windowsFileInvoker.InovkeExecute();

            WriteFileCommand windowsWriteFileCommand = new WriteFileCommand(fsWindows);
            windowsFileInvoker = new FileInvoker(windowsWriteFileCommand);
            windowsFileInvoker.InovkeExecute();

            CloseFileCommand windowsCloseFileCommand = new CloseFileCommand(fsWindows);
            windowsFileInvoker = new FileInvoker(windowsCloseFileCommand);
            windowsFileInvoker.InovkeExecute();


            Console.WriteLine("\n---------------Linux File System Operation------------------------------\n");
            IFileSystemReceiver fsLinux = new LinuxFileSystemReceiver();

            // Define
            FileInvoker linuxFileInvoker;

            // Create command and associate with Receiver.
            OpenFileCommand linuxOpenFileCommand = new OpenFileCommand(fsLinux);
            linuxFileInvoker = new FileInvoker(linuxOpenFileCommand);
            linuxFileInvoker.InovkeExecute();

            WriteFileCommand linuxWriteFileCommand = new WriteFileCommand(fsLinux);
            linuxFileInvoker = new FileInvoker(linuxWriteFileCommand);
            linuxFileInvoker.InovkeExecute();

            CloseFileCommand linuxCloseFileCommand = new CloseFileCommand(fsLinux);
            linuxFileInvoker = new FileInvoker(linuxCloseFileCommand);
            linuxFileInvoker.InovkeExecute();

            */

            //// =================================================================================================================================================
            
            // Example : 1 ==> High level Adapter Example (Code with RSV - You tube channel)

            /*
            string jsonData = "Random Json Data";
            AnalyticLibrary adaptee = new AnalyticLibrary();
            DataVisualizerAdapter adapter = new DataVisualizerAdapter(adaptee);
            adapter.DisplayGraph(jsonData);
            

            // Example : 2 ==> Dotnet Trick Example (Shailendra Chauhan)

            ICustomer customer = new CustomerAdapter();
            IEnumerable<CustomerDTO> data = customer.GetCustomers();

            foreach (CustomerDTO dto in data)
            {
                Console.WriteLine(string.Format("CustomerID: {0}, FullName: {1}, AddressDetails: {2}, Mobile: {3}",
                                 dto.CustomerId, dto.FullName, dto.AddressDetails, dto.Mobile));
            }
            */
            Console.ReadLine();
        }


    }
}
