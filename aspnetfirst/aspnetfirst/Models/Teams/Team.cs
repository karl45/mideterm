using aspnetfirst.Models.Players;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models.Teams
{
    public class Team
    { 
         public int TeamId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Coach { set; get; }
        public List<Player> players { set; get; }

        public int TotalSkill { set; get; }
        public int TotalExperience { set; get; }
    }
}
