﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenerics
{
    public class Array
    {
        public Array() { }

        public Array(string one, string two, string three, string four)
        { 

            // effektivt når man vet lengden på arrayen
            var colorOptions = new string[4];
            colorOptions[0] = one;
            colorOptions[1] = two;
            colorOptions[2] = three;
            colorOptions[3] = four;

            // collection initialiser
            string[] colorOptionsTwo = { "En", "To", "Tre"};

            // skrive ut som i javascript
            // iterere foreach eller for (kan editere under loop det kan man ikke paa foreach)

            // generics - type-safe


        }
        public V metodeNavn<V>(V resultvalue)

        {

            V value = resultvalue;
            return value;

        }

    }

    // brukes når parameteren varierer, nameprefix

    // sjekke opp --- Generic Constraints ---
    // where T : struct - value type
    // where T : class - reference
    // where T : new() - type med parameterløs const
    // where T : Vendor (arv)
    // where T : IVendor (interface)
  
     
    public class Generics<T>
    {

        public Generics()
        {
        }

        public Generics(T result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        

        public T Result { get; set; }
        public string Message { get; set; }


      

    }

    public class GenericList<T>
    {

        

        public GenericList()
        {
            var liste = new List<T>();

            Object value;
            //try get value
            if (value.enMetode("verdinavn", out value)
                {
                Console.WriteLine(value);
            }
            

        }

        public GenericList(T message) : this()
        {
            
        }

        

        public T Result { get; set; }
        public string Message { get; set; }




    }


    /// Generic Collection interface
    /// IEnumerable, ICollection, IList
    /// Arves av array og List automatisk, IDicionary kommer med directories
    /// public staic List<string> SendEmail(IList<vendor> vendors, string message) - kan da sende inn array eller liste
    /// Generic interface når man passer collections til metoder. 
    /// 
    /// IEnumerable -> kan iterere men ikke legge til fjerne elementer - readonly
    ///
    /// yield -> 
    ///
    ///









}
