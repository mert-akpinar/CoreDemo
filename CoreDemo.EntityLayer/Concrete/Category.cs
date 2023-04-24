using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; } 
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryStatus { get; set; }
    }
}
