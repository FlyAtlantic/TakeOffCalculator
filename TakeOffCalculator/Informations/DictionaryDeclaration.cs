using System;
using System.Collections.Generic;
using System.Device.Location;

public class DictionaryDeclaration
{
    public class AircraftPerformance
    {
        public Dictionary DictionaryDeclaration(Dictionary<short, PressAltTemperature> PressAltTemperature )
        {
            this.PressAltTemperature = PressAltTemperature;
        }

        public Dictionary<short, PressAltTemperature> PressAltTemperature
        { get; private set; }
    }
   

    public class PressAltTemperature
    {
        public PressAltTemperature(string result)
        {
            this.result = result;
        }

        public string result
        { get; private set; }

    }
}
