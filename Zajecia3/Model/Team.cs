using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia3.Model
{
    public class Team
    {
        public int Id{ get; set; }
        public string Name { get; set; }


        public ICollection<TeamMember> TeamMembers { get; set; }
    }
}
