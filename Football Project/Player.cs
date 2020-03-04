using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Project
{
    enum PlayerType
    {
        GoalKeeper, Forward, MidFielder, Defender
    }

    enum PositionType
    {
        NULL, GoalKeeper, RightMidfield, LeftMidfield, CentralDefence, RightBack, LeftBack, AttackingMidfield, RightWinger, LeftWinger, CentralForward, DefenceMidfield
    }

    class Player
    {
        public PlayerType Type { get; set;  }
        public string Name { get; set; }
        public int Number { get; set; }
        public List<PositionType> Positions { get; set; }
        public int Rating { get; set; }
        public int Caps { get; set; }

        public bool Injury { get; set; }

        public Player(String name, PlayerType ptype, int number, int rating, int caps, List<PositionType> positions)
        {
            this.Name = name;
            this.Type = ptype;
            this.Number = number;
            this.Rating = rating;
            this.Caps = caps;
            this.Positions = positions;
            this.Injury = false;
        }

        public Player() {
            this.Name = "Default";
            this.Type = PlayerType.GoalKeeper;
            this.Number = 0;
            this.Rating = 0;
            this.Caps = 0;
            this.Positions = new List<PositionType>();
            this.Injury = false;
        }

        public override string ToString()
        {
            return this.Name + ": " + this.Type.ToString();
        }

        public static Player createPlayer(String playerInfo)
        {
            String[] player = playerInfo.Split(',');
            PlayerType ptype = (PlayerType) Enum.Parse(typeof(PlayerType), player[0]);
            String name = player[1];
            int number = int.Parse(player[2]);
            List<PositionType> positions = new List<PositionType>();
            for (int i = 3; i < (player.Length - 2); i++)
            {
                positions.Add((PositionType)Enum.Parse(typeof(PositionType), player[i]));
            }
            int rating = int.Parse(player[player.Length - 2]);
            int caps = int.Parse(player[player.Length - 1]);

            Player p = new Player(name, ptype, number, rating, caps, positions);
            return p;
        }
    }
}
