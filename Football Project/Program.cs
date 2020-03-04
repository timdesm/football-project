using System;
using System.Collections.Generic;

namespace Football_Project
{
    class Program
    {
        public List<Player> Players { get; set; }

        static void Main(string[] args)
        {
            Player p = Player.createPlayer("MidFielder,Kevin De Bruyne,8,DefenceMidfield,RightMidfield,LeftMidfield,AttackingMidfield,92,80");
            Console.WriteLine(p.ToString());

        }

        public void setupPlayers(String filePath)
        {
            this.Players = new List<Player>();

            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach(String line in lines)
            {
                this.Players.Add(Player.createPlayer(line));
            }
        }
    }
}
