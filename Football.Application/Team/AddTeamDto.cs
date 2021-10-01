using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Application.Team
{
    public class AddTeamDto
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string ToLog()
        {
            return "Team: " + Name + "\nOwner: " + Owner;
        }
    }
}
