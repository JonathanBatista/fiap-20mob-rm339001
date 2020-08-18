using Amazon;
using Amazon.DynamoDBv2;

namespace Fiap20Mob.RM339001.Cloud.Api.Database
{
    public static class DynamoDbConnection
    {
        public static AmazonDynamoDBClient CreateClient()
        {
            try
            {
                var dynamoDBConfig = new AmazonDynamoDBConfig()
                {
                    RegionEndpoint = RegionEndpoint.APEast1,

                };
                var client = new AmazonDynamoDBClient(dynamoDBConfig);
                return client;
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
    }
}
