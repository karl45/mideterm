using aspnetfirst.Models.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models.Players
{
    public class Player
    {
        public int PlayerId { set; get; }
        public string Name { set; get; }
        public int Skill { set; get; }
        public int Expirience { set; get; }
        public int TeamId { set; get; }

    }
}
