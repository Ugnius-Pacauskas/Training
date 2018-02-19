using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HangedManWPF
{
    interface IHangedManGame
    {
        void Start();

        void GuessKey(Key key);

        KeyGuessState GetKeyGuessState();

        EGameState GetGameState();

        string GetHiddenWord();

        string GetLivesCount();
    }
}
