using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;

namespace JwtDecoder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the JWT token:");
            string? jwt = Console.ReadLine();

            if (string.IsNullOrEmpty(jwt))
            {
                Console.WriteLine("JWT token cannot be empty.");
                return;
            }

            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(jwt) as JwtSecurityToken;

            if (jsonToken != null)
            {
                var header = jsonToken.Header;
                var payload = jsonToken.Payload;
                var claims = jsonToken.Claims;


                string headerJson = JsonSerializer.Serialize(header, new JsonSerializerOptions { WriteIndented = true });
                string payloadJson = JsonSerializer.Serialize(payload, new JsonSerializerOptions { WriteIndented = true });
                string claimsJson = JsonSerializer.Serialize(claims, new  JsonSerializerOptions { WriteIndented = true });

                Console.WriteLine("Header JSON:");
                Console.WriteLine(headerJson);

                Console.WriteLine("Payload JSON:");
                Console.WriteLine(payloadJson);

                Console.WriteLine("Claims JSON:");
                Console.WriteLine(claimsJson);

                foreach (var tag in claims)
                {
                    var claimData = tag;
                    Console.WriteLine(claimData);
                }
            }
            else
            {
                Console.WriteLine("Invalid JWT token.");
            }
        }
    }
}
