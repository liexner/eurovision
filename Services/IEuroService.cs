using eurovision.Models;

namespace eurovision
{
    public interface IEuroService
    {
        public Task AddNewUser(string user);

        public Task RemoveUser(User user);
        public Task AsignCountryToUser();
        Task<List<User>> GetUsers();
        Task<List<Country>> GetCountries();

    }
}
