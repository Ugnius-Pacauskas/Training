using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangedManWPF
{

    public enum EGameState
    {
        None,
        Playing,
        Won,
        Lost
    }

    class GameState
    {
        public EGameState gameState { get; private set; }

        public GameState()
        {
            gameState = EGameState.None;
        }

        public void Start()
        {
            gameState = EGameState.Playing;
        }

        public void ChanngeGameState(bool isAlive, bool isGuesed)
        {
            if (!isAlive)
            {
                gameState = EGameState.Lost;
            }
            if (isGuesed)
            {
                gameState = EGameState.Won;
            }
        }
    }
}
