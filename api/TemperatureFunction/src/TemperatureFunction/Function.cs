using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace TemperatureFunction
{
    public class Function
    {
        
        /// <summary>
        /// This function will respond with a random 2-digit temperature while adding a log record to LogsDatabase
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(UnregisteredUser usr, ILambdaContext context)
        {
            LambdaLogger.Log($"Calling function name: {context.FunctionName}\n");
            return $"Welcome: {usr.firstName} {usr.surname}";
        }
    }


    public class UnregisteredUser {
        public string firstName { get; set; }
		public string surname { get; set; }
    }
}
