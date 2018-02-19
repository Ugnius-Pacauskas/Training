using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HangedManWPF
{
    class HangedManGame : IHangedManGame
    {
        WordsContainer words;
        SeacretWord hiddenWord;
        GameState gameState;
        Lives lives;
        KeyGuessState keyGuessState;

        public HangedManGame()
        {
            gameState = new GameState();
            lives = new Lives();
            words = new WordsContainer();
            keyGuessState = KeyGuessState.None;
        }

        public EGameState GetGameState()
        {
            return gameState.gameState;
        }

        public KeyGuessState GetKeyGuessState()
        {
            return keyGuessState;
        }

        public string GetLivesCount()
        {
            return lives.ToString();
        }

        public string GetHiddenWord()
        {
            return hiddenWord.GetHiddenWord();
        }

        public void GuessKey(Key key)
        {
            keyGuessState = KeyGuessState.None;
            string keyString = key.ToString();
            if (keyString.Length == 1)
            {
                char tempKey = keyString.ToLower()[0];
                if (Char.IsLetter(tempKey))
                {
                    keyGuessState = hiddenWord.GuessKey(tempKey);
                    if (keyGuessState == KeyGuessState.Incorect)
                    {
                        lives.LoseLive();
                    }
                }
                else
                {
                    keyGuessState = KeyGuessState.Invalid;
                }
            }
            else
            {
                keyGuessState = KeyGuessState.Invalid;
            }
            gameState.ChanngeGameState(lives.IsAlive(), hiddenWord.IsGuesed());
        }

        public void Start()
        {
            lives.ResetLives();
            hiddenWord = new SeacretWord(words.GetRandomWord());
            gameState.Start();
        }
    }
}
