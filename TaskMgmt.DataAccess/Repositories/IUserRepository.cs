using TaskMgmt.DataAccess.Models;
namespace TaskMgmt.DataAccess.Repositories
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> Get();
        public Task<User> GetByEmail(string email);
        public Task<int> Add(User user);
        public Task<bool> UserExists(string email);
        public Task EnrollUserToGroup(int userId, int groupId, bool isAdmin);
    }
}