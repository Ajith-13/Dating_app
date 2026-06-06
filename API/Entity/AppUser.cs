using System.Runtime.InteropServices.Marshalling;

namespace API.Entity
{
    public class AppUser
    {
        //public string Id { get; set; }="";
        //public required string Id { get; set; }
        public string Id { get; set; } = Guid.NewGuid().ToString();
        //this is BearerTokenExtensions create new Unique values
        public required string DisplayName { get; set; }
        public required string Email { get; set; }
    }
}
