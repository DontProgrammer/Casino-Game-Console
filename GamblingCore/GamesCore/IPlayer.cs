using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingGame.GamblingCore.GamesCore
{
    public interface IPlayer
    {
        string Name { get; }
        int Bet { get; }
    }
}
