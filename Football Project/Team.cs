using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Project
{
    enum SetupType
    {
        NORMAL, BEST ,ROTATION
    }

    enum FormatType
    {
        F442, F532
    }

    class Team
    {
        public String Name { get; set; }
        public List<TeamPlayer> Players { get; set; }

        public Player Captain { get; set; }

        public Team(String name, Player captain, List<Player> players)
        {
            this.Name = name;
            this.Captain = captain;
            this.Players = new List<TeamPlayer>();
            foreach (Player p in players)
            {
                TeamPlayer tp = (TeamPlayer)p;
                tp.Position = PositionType.NULL;
                this.Players.Add(tp);
            }
        }

        public void setupTeam()
        {
            foreach(TeamPlayer p in this.Players)
            {
                p.Position = PositionType.NULL;
            }

            List<TeamPlayer> ordered = this.Players;
            ordered.Sort((x, y) => { return x.Rating - y.Rating; });

            int Defenders = 4;
            int MidFielders = 4;
            int Forwards = 2;

            int foundDefenders = 0;
            int foundMidFielders = 0;
            int foundForwards = 0;


            foreach (TeamPlayer tp in ordered)
            {
               
            }
        }
    }
}
