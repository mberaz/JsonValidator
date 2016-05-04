
namespace JsonValidator
{
    public class UserModel
    {
        public string name { get; set; }
        public int id { get; set; }
        public Homeaddress homeAddress { get; set; }
        public string[] nicknames { get; set; }
    }

    public class Homeaddress
    {
        public string city { get; set; }
        public string street { get; set; }
        public int houseNumber { get; set; }
    }

}
