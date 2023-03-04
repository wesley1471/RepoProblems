using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyState.Entities
{
    internal class Estado
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Estado(string name, double value) 
        {
            Name = name;
            Value = value;
        
        }

        

    }
}
