using ServiceReference;
// Instantiate the Service wrapper specifying the binding and optionally the Endpoint URL. The BasicHttpBinding could be used instead.

var client  = new NumberConversionSoapTypeClient(NumberConversionSoapTypeClient.EndpointConfiguration.NumberConversionSoap,
            "https://www.dataaccess.com/webservicesserver/NumberConversion.wso");

Console.WriteLine("Going to call the web service...");
var response = await client.NumberToWordsAsync(46);

Console.WriteLine($"The response is: {response.Body.NumberToWordsResult}");
