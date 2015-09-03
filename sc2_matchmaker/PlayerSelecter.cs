using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sc2_matchmaker
{
    class PlayerSelecter
    {
        List<Player> players;
        List<Player> assignedPlayers=new List<Player>();
        List<Player> nonAssignedPlayers=new List<Player>();
        Random rnd = new Random();

        public PlayerSelecter(List<Player> players)
        {
            this.players = players;
            reset();
        }

        public void reset()
        {
            nonAssignedPlayers.Clear();
            foreach(var player in players)
            {
                nonAssignedPlayers.Add(player);
                assignedPlayers.Clear();
            }
        }

        public Player getRandomPlayer()
        {
            Player player = null;
            if (nonAssignedPlayers.Count > 0)
            {
                int index = rnd.Next(nonAssignedPlayers.Count);
                player = nonAssignedPlayers[index];
                nonAssignedPlayers.Remove(player);
                assignedPlayers.Add(player);
            }
            return player;
        }

        public Player getNextPlayer()
        {
            Player player = null;
            if (nonAssignedPlayers.Count > 0)
            {
                int index = 0;
                player = nonAssignedPlayers[index];
                nonAssignedPlayers.Remove(player);
                assignedPlayers.Add(player);
            }
            return player;
        }


    }
}
