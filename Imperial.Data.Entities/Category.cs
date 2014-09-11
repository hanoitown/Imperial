using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imperial.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public ICollection<Measurement> KPIs { get; set; }

        public Category()
        {
            KPIs = new List<Measurement>();
        }
    }
}
