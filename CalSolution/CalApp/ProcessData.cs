using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalApp
{
    public class ProcessData
    {
        public static decimal Process(decimal num1,decimal num2,Operation del)
        {
            var result = del(num1, num2);
            return result;
        }
    }
}
