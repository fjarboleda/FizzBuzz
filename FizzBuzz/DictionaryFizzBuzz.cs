using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class DictionaryFizzBuzz : IFizzBuzz
    {   
        public const sbyte MinimunValue = 1;    
        public const sbyte MaximunValue = 100;
        private readonly IDictionary<sbyte, string> _cache= null;


        public DictionaryFizzBuzz()
        {
          _cache = CreateDictionary();
        }

        private Dictionary<sbyte, string> CreateDictionary()
        {
            var result = new Dictionary<sbyte, string>();
                   
            for(sbyte i=MinimunValue; i<=MaximunValue; ++i)
            {
                result[i] = ComputeFizzBuzz(i);
            } 
            
            return result;
        }


        public string FizzBuzz(sbyte inputValue)
        {
            if(_cache.ContainsKey(inputValue))
            {
                return _cache[inputValue];
            }

            throw new ArgumentException(nameof(inputValue), $"{inputValue}");
          
        }

        private string ComputeFizzBuzz(sbyte inputClean)
        {
            string result = "";

            if(0 == inputClean % 3)
            {
                result+= "Fizz";
            }

            if(0 == inputClean % 5) 
            {
                result+= "Buzz";
            }

            if(string.IsNullOrEmpty(result))
            {
                result = Convert.ToString(inputClean);
            }

            return result;
        }

  }
}