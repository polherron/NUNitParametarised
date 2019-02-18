using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class ResultsMethods
    {


        public static void AddResult(CDTResult result)
        {
            using (var dbContext = new ResultsDataContext())
            {
                var myResult = new TestResult
                {
                    MethodName = result.MethodName,
                    Result = result.Result
                };
                dbContext.TestResults.InsertOnSubmit(myResult);
                dbContext.SubmitChanges();
            }
        }
    }
}


