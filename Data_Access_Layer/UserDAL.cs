using Data_Access_Layer.Repository;
using Data_Access_Layer.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data_Access_Layer
{
    public class UserDAL
    {
        private readonly UserDbContext _userDbContext;
        public UserDAL(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public List<User> GetUsers()
        {
             return _userDbContext.users.ToList(); 
        }

        public User GetUserbyId(int id) 
        {
            var user = _userDbContext.users.FirstOrDefault(x => x.Id == id);
            return user;
        }
        public void PostUser(User user)
        {
            _userDbContext.users.Add(user);
            _userDbContext.SaveChanges();
        }
    }
}