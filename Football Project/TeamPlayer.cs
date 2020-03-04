using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Project
{
    class TeamPlayer : Player
    {
        public PositionType Position { get; set; }

        public TeamPlayer(Player p, PositionType position)
        {
            this.Name = p.Name;
            this.Type = p.Type;
            this.Number = p.Number;
            this.Rating = p.Rating;
            this.Caps = p.Caps;
            this.Positions = p.Positions;
            this.Injury = p.Injury;

            this.Position = position;
        }
    }
}
