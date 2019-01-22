using Amazon.DynamoDBv2;
using Amazon.Runtime;
using System;

namespace Week06ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var accessKeyId = "AKIAJDBPBJWAYUCYZREA";
            var secretKey = "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";
            AWSCredentials credentials = new BasicAWSCredentials(accessKeyId, secretKey);
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(credentials, Amazon.RegionEndpoint.USEast2);

            //ObjectModelSample.ExecuteAsyn(client).Wait();

            DocumentModelSample.ExecuteAsyn(client).Wait();

            Console.WriteLine("Saved");

            Console.ReadKey();


           // Console.WriteLine("Hello World!");
        }
    }
}
