using System.Collections.Generic;

namespace CalculatorLibrary.AutoFixtureExample
{
    public class DataProcessor
    {
        public DataParameters Process(DataParameters data)
        {
            //Data processing logic...
            return data;
        }
    }

    public class DataParameters
    {
        public List<decimal> Set { get; set; } 
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public decimal Average { get; set; }
        public decimal Mediana { get; set; }
        public string Name { get; set; }
    }
}
