using GamblingGame.GamblingCore.GamesCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingGame.GamblingCore.CasinoGames
{
    internal class TwentyOneGame : IGame
    {
        public string Name { get; } = "Twenty one";
        public string Description { get; } = "First test game.";
        public string GameState { get; }
        public List<IPlayer> Players { get => _players; }

        public int MaxPlayers { get; } = 2;
        public int MinPlayers { get; } = 1;

        private List<IPlayer> _players;

        public TwentyOneGame(List<IPlayer> players,bool startNow = false)
        {
            _players = players;
            if (startNow) Start(); 
        }
        

        public void AddUser(IPlayer player)
        {
            if(_players.Count < 2 ) _players.Add(player);
            else
            {
                Console.WriteLine("Max player limit. Deny");
            }
        }

        public void RemoveUser(string username)
        {
            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i].Name == username)
                {
                    _players.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("Player not found.");
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }

        public void RemoveUser(IPlayer username)
        {
            throw new NotImplementedException();
        }
    }
}
