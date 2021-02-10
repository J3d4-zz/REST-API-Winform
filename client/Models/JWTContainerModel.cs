using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace client.Models
{
    public class JWTContainerModel : IAuthContainerModel
    {
        public int ExpireMinutes { get; set; } = 10080;
        public string SecretKey { get; set; } = "MIIBOgIBAAJBAIE7yK70OfXFcsnquMbsAPTbzZM92vQms88rSxnHoFhEiyZDPKa30wMb7xkf3m7SEfRCp7/HKQGauVV0CQhbSJ0CAwEAAQJAH2unqVHb3bN56znUXxj2SpI+czQwzfey9AW0prnwdEUqWx/G8TASbOrsig/Z73vtq3FzvW61kS8oVCMPWKi9yQIhAO4cuAUf/F3iCBVyZS2t2aoHMqWyz0YklNYrEjXPZELLAiEAivEnL+1xl01mFgttJ5czQRZ+2KZUaW+qD3SePhmR7TcCIQDNynJcs41Ikq7L4meBuCxT4A6s2MJ9a+ZaxzTg3tJXSwIgXv7SVCp75367tYbKcq8mE/JVd7sBK7V1CGwrZToGU7ECIEwSgZtk538L7EQ3inp2HiySC9kQlO4OTzSnyuWLHg6U";
        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha256Signature;

        public Claim[] Claims { get; set; }
    }
}