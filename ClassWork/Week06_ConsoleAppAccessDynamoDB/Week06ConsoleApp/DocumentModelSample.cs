using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Week06ConsoleApp
{
    public static class DocumentModelSample
    {
        public static async Task ExecuteAsyn(AmazonDynamoDBClient client)
        {
            Table userTable = Table.LoadTable(client, "Users", DynamoDBEntryConversion.V2);
            Document newUser = new Document();

            newUser["Id"] = "sampleEmail@gmail.com";
            newUser["Name"] = "John Smith";
            newUser["Active"] = true;
            newUser["Hobby"] = new List<string> { "Soccer", "Chilling", "Yoga" };

            Document skills = new Document();
            skills["C#"] = 3;
            skills["Java"] = 4;
            skills["Python"] = 1;

            newUser["Skills"] = skills;
            await userTable.PutItemAsync(newUser);
        }
    }
}
