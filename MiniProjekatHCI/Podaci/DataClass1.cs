using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekatHCI.Podaci
{
    public class DataClass1
    {
        public string name { get; set; }
        public string interval { get; set; }

        public string unit { get; set; }    

        public IEnumerable<Value1> data { get; set; }
        public DataClass1() { 

        }

    }

    public class Value1 { 
        public string value { get; set; }

        public string date { get; set; }

        public Value1() { }
    }
}
