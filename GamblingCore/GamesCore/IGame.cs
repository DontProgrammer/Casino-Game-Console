using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingGame.GamblingCore.GamesCore
{
    public interface IGame
    {
        public string Name { get; }
        public string Description { get; }
        public string GameState { get; }
        public int MaxPlayers { get; }
        public int MinPlayers { get; }

        List<IPlayer> Players { get; }


        public void Start();
        public void Stop();
        public void AddUser(IPlayer player);
        public void RemoveUser(IPlayer username);
    }
}
