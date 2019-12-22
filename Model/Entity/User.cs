using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public List<Feeder> Feeders { get; set; }

        public User()
        {
            Feeders = new List<Feeder>();
        }
    }
}
