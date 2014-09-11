using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperial.Data.Entities
{
    public class Measurement
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public bool IsRequired { get; set; }
        public UnitOfMeasure Unit { get; set; }
        public Category Category { get; set; }
    }
}
