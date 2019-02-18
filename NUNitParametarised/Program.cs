using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace NUNitParametarised
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTestData = TestData.GetTestData();
            foreach (var item in myTestData)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
