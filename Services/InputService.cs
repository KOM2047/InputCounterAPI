using System;
using System.Collections.Generic;
using System.Linq;


namespace InputCounterAPI.Services
{
    public class InputService
    {
        // Method to count occurences of each unique input
        public Dictionary<object, int> CountOccurrences(List<object> items) 
        {
            return items.GroupBy(i => i).ToDictionary(g => g.Key, g => g.Count());
        }

        // Method to automatically detect the data type of user input
        public object ParseInput(string input)
        {
            if (int.TryParse(input, out int intResult)) return intResult;
            if (double.TryParse(input, out double doubleResult)) return doubleResult;
            if (bool.TryParse(input, out bool boolResult)) return boolResult;
            if (DateTime.TryParse(input, out DateTime dateResult)) return dateResult;
            return input;
        }

        // Method to parse a list of inputs and convert them into detected data types
        public List<object> ParseInputs(List<string> inputs)
        {
            return inputs.Select(ParseInput).ToList();
        }
    }
}
