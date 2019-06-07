using System;
using Entity;
using Entity.Factory;
using System.Collections.Generic;
using Repository;

namespace Business
{
    public class UserControls
    {
        //ConcreteCreator pagecrtor = new ConcreteCreator();
        UserRepo usrRep = new UserRepo();
        public void AddUser(string name, string gender, DateTime birthday, string email)
        {

            User newUser = new User
            {
                ID = new Guid(),
                Name = name,
                Gender = gender,
                Birthday = birthday,
                Email = email,
                DateCreated = DateTime.Now
            };

            usrRep.AddUserToRepo(newUser);
        }

        public void DeleteUser(Guid id)
        {
            usrRep.DeleteUserInRepo(id);
        }
    }
}
