//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace comp2007_s2016_team_proj.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public System.DateTime GameDate { get; set; }
        public string GameDescription { get; set; }
        public string WinTeam { get; set; }
        public string WinTeamDescription { get; set; }
        public int WinTeamScore { get; set; }
        public string LostTeam { get; set; }
        public string LostTeamDescription { get; set; }
        public int LostTeamScore { get; set; }
        public int NumSpectators { get; set; }
    }
}
