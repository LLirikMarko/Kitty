using Model;
using Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepository : IRepository<User>
    {
        private static List<User> _data = new List<User>();
        private static int _end_index = 0;
        public int Add(User obj)
        {
            foreach (var user in _data)
                if (user.Name == obj.Name)
                    throw new ArgumentException("User already exist");

            obj.Id = _end_index;
            _end_index += 1;
            _data.Add(obj);
            return obj.Id;
        }

        public void Update(User obj)
        {
            var character = _data.Find(c => c.Id == obj.Id);
            if (character != null)
                character.Name = obj.Name;
        }

        public void Save()
        {
        }

        public User Find(int id)
        {
            return _data.Find(c => c.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _data;  // create copy to avoid update via reference
        }

    }
}
