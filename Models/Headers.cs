using System.Text.Json;

namespace RobotControlSystem.Models
{
    public class Headers
    {
        public string token { get; set; }
        public string name { get; set; }
    }

    public class CheckHeaders : Headers
    {
        Headers headers;

        string pathOfHeaderConfig = "./Configs/header.json";
        string requestToken;
        string requestName;

        public int check(IHeaderDictionary requestHeaders)
        {
            // Check if request headers contain two keys as below.
            if (!(requestHeaders.ContainsKey("token") || requestHeaders.ContainsKey("name")))
            {
                return StatusCodes.Status401Unauthorized;
            }

            // Get the value of two keys from request headers as below.
            requestToken = requestHeaders["token"];
            requestName = requestHeaders["name"];

            // Check if the value from request headers is the same as define.
            using (FileStream fs = File.OpenRead(pathOfHeaderConfig))
            {
                headers = JsonSerializer.Deserialize<Headers>(fs);
                Console.WriteLine($"token={headers.token}, name={headers.name}");
                Console.WriteLine($"requestToken={requestToken}, requestName={requestName}");

                if (requestToken != headers.token || requestName != headers.name)
                {
                    return StatusCodes.Status403Forbidden;
                }
            }

            return StatusCodes.Status200OK;
        }
    }
}
