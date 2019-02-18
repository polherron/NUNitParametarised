using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TestData
    {
        public TestData(int a, int b, int expected)
        {
            this.a = a;
            this.b = b;
            this.expected = expected;
        }
        public TestData()
        {

        }

        public int a { get; set; }
        public int b { get; set; }
        public int expected { get; set; }



        public static IEnumerable<TestData> TestCases
        {

            get
            {
                yield return new TestData(1, 2, 4);
                yield return new TestData(1, 2, 3);
            }
        }



        public static List<TestData> GetTestData()
        {
            using (var myDataContext = new DataClasses1DataContext())
            {
                var myResults = new List<TestData>();

                var myData = myDataContext.TestDataMaths;

                foreach (var item in myData)
                {
                    var testDataItem = new TestData()
                    {
                        a = (int)item.a,
                        b = (int)item.b,
                        expected = (int)item.expected
                    };
                    myResults.Add(testDataItem);
                }

                return myResults;
            }
        }
    }
}
