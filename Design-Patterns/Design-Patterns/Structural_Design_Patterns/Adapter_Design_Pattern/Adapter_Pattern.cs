using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Design_Patterns.Adapter_Design_Pattern
{
    public class Adapter_Pattern
    {
        // Adaptee Class
        public class AnalyticLibrary
        {
            public void DisplayGraphByAdaptee(CustomLibraryObject customObj)
            {
                Console.WriteLine("Display graphs based on received custom object");
                
            }
        }

        public class CustomLibraryObject
        {
            
        }

        // Targer Adapter Interface
        public interface IDataVisualizer
        {
            void DisplayGraph(string jsonData);
        }


        // Adapter Class
        public class DataVisualizerAdapter : IDataVisualizer {

            private readonly AnalyticLibrary _adaptee;

            public DataVisualizerAdapter(AnalyticLibrary adaptee)
            {
                _adaptee = adaptee;
            }

            // Implementation of Adapter Interface.
            public void DisplayGraph(string jsonData)
            {
                CustomLibraryObject obj = GetObjFromJSON(jsonData);
                _adaptee.DisplayGraphByAdaptee(obj);
            }

            // Method to convert JSON data into library object
            private CustomLibraryObject GetObjFromJSON(string jsonData) {

                // Convert JSON data to library object
                return new CustomLibraryObject();
            }
        }
    }
}
