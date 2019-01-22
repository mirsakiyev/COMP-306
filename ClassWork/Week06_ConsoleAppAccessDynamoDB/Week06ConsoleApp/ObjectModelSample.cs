using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Week06ConsoleApp
{
    public static class ObjectModelSample
    {
        public static async Task ExecuteAsyn(AmazonDynamoDBClient client)
        {
            var context = new DynamoDBContext(client);

            var user = new User { Email = "comp306003@gmail.com", FirstName="Aslan", LastName="Mirsakiyev" };

            await context.SaveAsync<User>(user);
        }
    }
}
