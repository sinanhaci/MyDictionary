using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string, int> myDictionary = new MyDictionary<string, string, int>();
            myDictionary.Add("Sinan", "Hacı", 26);
            myDictionary.Add("Nihat", "Hacı", 20);
            myDictionary.Add("Okur", "Gezer", 33);
            myDictionary.Add("Fikri", "Hür", 99);

            myDictionary.Read();
            
        }
    }
}
