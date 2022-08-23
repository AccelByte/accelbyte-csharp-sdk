using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using Amazon.Lambda.APIGatewayEvents;


namespace AccelByte.Sdk.Sample.TitleMatchmaking.Aws.Tests;

public class FunctionTest
{
    public FunctionTest()
    {
    }

    [Fact]
    public void TestGetMethod()
    {
        TestLambdaContext context;
        APIGatewayProxyRequest request;
        APIGatewayProxyResponse response;

        Functions functions = new Functions();


        request = new APIGatewayProxyRequest();
        context = new TestLambdaContext();
        response = functions.GetTest(request, context);
        Assert.Equal(200, response.StatusCode);
        Assert.Equal("Hello AWS Serverless", response.Body);
    }
}