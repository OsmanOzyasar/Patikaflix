using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix
{
    public class Series
    {
        private int year = 0;
        public string Name { get; set; }
        public int Year {  get; set; }
        public string Type { get; set; }
       
        public string Director { get; set; }
        public string Channel { get; set; }
    }
}
