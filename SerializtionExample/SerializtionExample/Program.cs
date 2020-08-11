using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CalculatorLib;
using System.Runtime.Serialization;

namespace SerializtionExample
{
    [Serializable]
    
    class Program
    {
        static void Main(string[] args)
        {
            ClassCal objcal = new ClassCal();
            FileStream fs = new FileStream("Calculator.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter xs = new BinaryFormatter();
            xs.Serialize(fs, objcal);
            Console.WriteLine("Text File Created");
        }
    }
}
