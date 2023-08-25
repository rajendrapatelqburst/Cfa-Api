using Data_Access_Layer;
using Data_Access_Layer.Repository.Models;

namespace Business_Logic_Layer
{
    public class UserBLL : IUserBLL
    {
        private UserDAL _userDAL;
      
        public UserBLL(UserDAL userDAL) 
        {
            _userDAL = userDAL;
           

        }
        public List<User> GetUsers()
        {
            return _userDAL.GetUsers();
        }

        public async Task<User> GetUserbyId(int id)
        {
            var user = _userDAL.GetUserbyId(id);
            if(user == null)
            {
                throw new Exception("Invalid Id");
            }
            return user;
        }

        

        public void PostUser(User user)
        {
            _userDAL.PostUser(user);
        }
    }
}