using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class UserRepo
    {
        public List<User> UserList = new List<User>()
        {
            new User {ID=new Guid(), Name="John", Birthday = new DateTime(2017, 1, 18), Email = "haha@yahoo.com"},
            new User {ID=new Guid(), Name="Mark", Birthday = new DateTime(1998, 4, 15), Email = "ahah@yahoo.com"}
        };

        public void AddUserToRepo(User newUser)
        {
            UserList.Add(newUser);
        }

        public void DeleteUserInRepo(Guid id)
        {
            UserList.RemoveAll(a => a.ID == id);
        }
    }
}
