using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CalculatorLib
{
    [Serializable]
    
    public class ClassCal
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        
        public double CalAdd()
        {
            return Num1 + Num2;
        }
        public double CalSub()
        {
            return Num1 - Num2;
        }
        public double CalMul()
        {
            return Num1 * Num2;
        }
        public double CalDiv()
        {
            return Num1 / Num2;
        }
        

    }
}
