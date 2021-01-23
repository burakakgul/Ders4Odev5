using System;
using System.Collections.Generic;

namespace Ders4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {            
             
            // Dictionary sınıfı kullanımı Dictionary<TKey,TValue> 
            Dictionary<int, string> MyDictionary = new Dictionary<int, string>();

            // key/value birlikte Add komutu ile eklenişi 
            // Dictionary Add() methodu kullanımı 
            MyDictionary.Add(123, "Yazılım");
            MyDictionary.Add(124, "Geliştirici Yetiştirme");
            MyDictionary.Add(125, "Kampı");

            Console.WriteLine(MyDictionary[123]);
            Console.WriteLine(MyDictionary[124]);
            Console.WriteLine(MyDictionary[125]);

                       

        }
    }
}
