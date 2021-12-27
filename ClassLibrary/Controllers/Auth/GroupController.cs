using ClassLibrary.Entities.Auth;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers.Auth
{
    public class GroupController : IController<Group>
    {
        private AuthModel _model;

        public List<Group> GroupWithPolicies { get; set; }

        public GroupController()
        {
            _model = AuthModel.GetInstanse();
            GroupWithPolicies = new List<Group>();
            GroupWithPolicies.Add(_model.Groups.FindLast(g => g.Name == "root"));
        }

        public bool Create(Group Group)
        {
            if (_model.CurentUser.checkPolities(GroupWithPolicies))
            {
                _model.Groups.Add(Group);
                return true;
            }

            return false;
        }

        public Group Read(Guid Id)
        {
            return _model.Groups.Where(g => g.Id == Id).FirstOrDefault();
        }

        public List<Group> ReadAll()
        {
            return _model.Groups.ToList<Group>();
        }

        public bool Update(Guid Id, Group Item)
        {
            Group g = _model.Groups.Where(gr => gr.Id == Id).FirstOrDefault();

            if(_model.Groups.Remove(g))
            {
                _model.Groups.Add(Item);
                return true;
            }

            return false;
        }

        public bool Delete(Guid Id)
        {
            _model.Groups.Remove(_model.Groups.Where(g => g.Id == Id).FirstOrDefault());
            return true;
        }
    }
}
