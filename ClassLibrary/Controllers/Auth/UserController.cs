using ClassLibrary.Entities.Auth;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers.Auth
{
    public class UserController : IController<User>
    {
        private AuthModel _model;

        public List<Group> GroupWithPolicies { get; set; }

        public UserController()
        {
            _model = AuthModel.GetInstanse();
            GroupWithPolicies = new List<Group>();
            GroupWithPolicies.Add(_model.Groups.FindLast(g => g.Name == "guest"));
            GroupWithPolicies.Add(_model.Groups.FindLast(g => g.Name == "root"));
        }

        public bool Create(User Item)
        {
            _model.Users.Add(Item);
            return true;
        }

        public User Read(Guid Id)
        {
            return _model.Users.Where(u => u.Id == Id).FirstOrDefault();
        }

        public List<User> ReadAll()
        {
            return _model.Users;
        }

        public bool Update(Guid Id, User Item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid Id)
        {
            return _model.Users.Remove(_model.Users.Where(u => u.Id == Id).FirstOrDefault());
        }
    }
}
