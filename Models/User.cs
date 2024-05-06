namespace eurovision.Models
{
    public class User
    {
        public string Name;
        public List<Country> Countries;
        public User(string name)
        {
            Name = name;
            Countries = new List<Country>();
        }
    }
}
