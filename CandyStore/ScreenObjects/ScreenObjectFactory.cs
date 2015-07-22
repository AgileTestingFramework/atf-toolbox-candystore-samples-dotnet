using System;
using System.Collections.Generic;

namespace CandyStore.ScreenObjects
{
    public class ScreenObjectFactory
    {
        private static Dictionary<string, Object> instances = new Dictionary<string, Object>();
        
        /** Create all screen object constants here for easy access **/
        public static string CALCULATOR = "calculator";
        public static string DESKTOP = "desktop";
        public static string TEMPERATURE = "temperature";

        private ScreenObjectFactory() { }
        
        private static object _syncPageObjectCreator = new Object();

        public static Object Instance(string screenObjectType)
        {
            Object instance = null;

            if (instances.ContainsKey(screenObjectType))
            {
                // Our "per key" singleton
                instance = instances[screenObjectType];
            }
            else
            {
                lock (_syncPageObjectCreator)
                {
                    // Lazily create new instance of the page object
                    if (screenObjectType == CALCULATOR) { instance = new CalculatorScreen(); }
                    else if (screenObjectType == TEMPERATURE) { instance = new TemperatureScreen(); }

                    // Add it to map   
                    instances.Add(screenObjectType, instance);
                }
            }

            // Do any common initialization here
        
            return instance;
        }

        
    }
}

