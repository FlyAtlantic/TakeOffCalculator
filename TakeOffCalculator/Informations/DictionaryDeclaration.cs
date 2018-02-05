using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
