using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TName, TLastName, TAge>
    {
        TName[] names;
        TLastName[] lastNames;
        TAge[] ages;
        public MyDictionary()
        {
            names = new TName[0];
            lastNames = new TLastName[0];
            ages = new TAge[0];
        }
        public void Add(TName name, TLastName lastName, TAge age)
        {
            TName[] tempName = names;
            TLastName[] tempLastName = lastNames;
            TAge[] tempAge = ages;

            names = new TName[names.Length + 1];
            lastNames = new TLastName[lastNames.Length + 1];
            ages = new TAge[ages.Length + 1];

            for (int i = 0; i < tempName.Length; i++)
            {
                names[i] = tempName[i];
                lastNames[i] = tempLastName[i];
                ages[i] = tempAge[i];
            }
            names[names.Length - 1] = name;
            lastNames[lastNames.Length - 1] = lastName;
            ages[ages.Length - 1] = age;
        }
        public void Read()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("İsim : " + names[i] + " , " + "Soyisim : " + lastNames[i] + " , " + "Yas : " + ages[i]);
            }
        }
    }
    
}
