using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CDTResult
    {
        public CDTResult(string methodName, string result)
        {
            MethodName = methodName;
            Result = result;
        }

        public string MethodName { get; set; }
        public string Result { get; set; }
    }

}
