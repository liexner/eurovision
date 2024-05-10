using eurovision.Models;

namespace eurovision.Services
{
    public class EuroService : IEuroService
    {
        public List<Country> _countries;
        public List<User> _users;

        //constructor
        public EuroService()
        {
            _countries = new List<Country>();
            _users = new List<User>();

            _countries.Add(new Country("Sweden", "https://upload.wikimedia.org/wikipedia/en/thumb/4/4c/Flag_of_Sweden.svg/23px-Flag_of_Sweden.svg.png"));
            _countries.Add(new Country("Ukraine", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Flag_of_Ukraine.svg/23px-Flag_of_Ukraine.svg.png"));
            _countries.Add(new Country("Germany", "https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/Flag_of_Germany.svg/23px-Flag_of_Germany.svg.png"));
            _countries.Add(new Country("Luxembourg", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Flag_of_Luxembourg.svg/23px-Flag_of_Luxembourg.svg.png"));
            _countries.Add(new Country("Netherlands", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Flag_of_the_Netherlands.svg/23px-Flag_of_the_Netherlands.svg.png"));
            _countries.Add(new Country("Israel", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Flag_of_Israel.svg/21px-Flag_of_Israel.svg.png"));
            _countries.Add(new Country("Lithuania", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Flag_of_Lithuania.svg/23px-Flag_of_Lithuania.svg.png"));
            _countries.Add(new Country("Spain", "https://upload.wikimedia.org/wikipedia/en/thumb/9/9a/Flag_of_Spain.svg/23px-Flag_of_Spain.svg.png"));
            _countries.Add(new Country("Estonia", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/Flag_of_Estonia.svg/23px-Flag_of_Estonia.svg.png"));
            _countries.Add(new Country("Ireland", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/Flag_of_Ireland.svg/23px-Flag_of_Ireland.svg.png"));
            _countries.Add(new Country("Latvia", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Flag_of_Latvia.svg/23px-Flag_of_Latvia.svg.png"));
            _countries.Add(new Country("Greece", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Flag_of_Greece.svg/23px-Flag_of_Greece.svg.png"));
            _countries.Add(new Country("United Kingdom", "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Flag_of_the_United_Kingdom.svg/23px-Flag_of_the_United_Kingdom.svg.png"));
            _countries.Add(new Country("Norway", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Flag_of_Norway.svg/21px-Flag_of_Norway.svg.png"));
            _countries.Add(new Country("Italy", "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/Flag_of_Italy.svg/23px-Flag_of_Italy.svg.png"));
            _countries.Add(new Country("Serbia", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/ff/Flag_of_Serbia.svg/23px-Flag_of_Serbia.svg.png"));
            _countries.Add(new Country("Finland", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Finland.svg/23px-Flag_of_Finland.svg.png"));
            _countries.Add(new Country("Portugal", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Flag_of_Portugal.svg/23px-Flag_of_Portugal.svg.png"));
            _countries.Add(new Country("Armenia", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Flag_of_Armenia.svg/23px-Flag_of_Armenia.svg.png"));
            _countries.Add(new Country("Cyprus", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Flag_of_Cyprus.svg/23px-Flag_of_Cyprus.svg.png"));
            _countries.Add(new Country("Switzerland", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Flag_of_Switzerland_%28Pantone%29.svg/16px-Flag_of_Switzerland_%28Pantone%29.svg.png"));
            _countries.Add(new Country("Slovenia", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Flag_of_Slovenia.svg/23px-Flag_of_Slovenia.svg.png"));
            _countries.Add(new Country("Croatia", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Croatia.svg/23px-Flag_of_Croatia.svg.png"));
            _countries.Add(new Country("Georgia", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Flag_of_Georgia.svg/23px-Flag_of_Georgia.svg.png"));
            _countries.Add(new Country("France", "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/23px-Flag_of_France.svg.png"));
            _countries.Add(new Country("Austria", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_Austria.svg/23px-Flag_of_Austria.svg.png"));
            //_countries.Add(new Country("Albania", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Flag_of_Albania.svg/21px-Flag_of_Albania.svg.png"));
            //_countries.Add(new Country("Australia", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/88/Flag_of_Australia_%28converted%29.svg/23px-Flag_of_Australia_%28converted%29.svg.png"));
            //_countries.Add(new Country("Azerbaijan", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Flag_of_Azerbaijan.svg/23px-Flag_of_Azerbaijan.svg.png"));
            //_countries.Add(new Country("Belgium", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_Belgium_%28civil%29.svg/23px-Flag_of_Belgium_%28civil%29.svg.png"));
            //_countries.Add(new Country("Czechia", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Flag_of_the_Czech_Republic.svg/23px-Flag_of_the_Czech_Republic.svg.png"));
            //_countries.Add(new Country("Denmark", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Flag_of_Denmark.svg/20px-Flag_of_Denmark.svg.png"));
            //_countries.Add(new Country("Iceland", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ce/Flag_of_Iceland.svg/21px-Flag_of_Iceland.svg.png"));
            //_countries.Add(new Country("Malta", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Malta.svg/23px-Flag_of_Malta.svg.png"));
            //_countries.Add(new Country("Moldova", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Flag_of_Moldova.svg/23px-Flag_of_Moldova.svg.png"));
            //_countries.Add(new Country("Poland", "https://upload.wikimedia.org/wikipedia/en/thumb/1/12/Flag_of_Poland.svg/23px-Flag_of_Poland.svg.png"));
            //_countries.Add(new Country("San Marino", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Flag_of_San_Marino.svg/20px-Flag_of_San_Marino.svg.png"));


        }

        public async Task AddNewUser(string user)
        {
            _users.Add(new User(user));
        }

        public async Task AsignCountryToUser()
        {
            if(!_countries.Any() || !_users.Any()) //if there are no countries left
            {
                return;
            }
            var userWithFewestCountries = _users.OrderBy(u => u.Countries.Count).First();
            var random = new Random();
            var country = _countries[random.Next(_countries.Count)];

            userWithFewestCountries.Countries.Add(country);
            _countries.Remove(country);
        }

        public Task<List<Country>> GetCountries()
        {
            return Task.FromResult(_countries);
        }

        public Task<List<User>> GetUsers()
        {
            return Task.FromResult(_users);
        }

        public async Task RemoveUser(User user)
        {
            foreach (var country in user.Countries)
            {
                _countries.Add(country);
            }
            _users.Remove(user);

        }
    }
}
