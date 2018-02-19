using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HangedManWPF
{
    public enum KeyGuessState
    {
        None,
        Incorect,
        Correct,
        AlreadyGuessed,
        Invalid
    }

    class SeacretWord
    {

        private string seacretWord;
        private List<char> guessedChars;
        private List<char> correctChars;
        private int seacretWordUniqueCharCount;

        public SeacretWord(string seacretWord)
        {
            this.seacretWord = seacretWord;
            seacretWordUniqueCharCount = seacretWord.Distinct().Count();
            guessedChars = new List<char>();
            correctChars = new List<char>();
        }

        public bool IsGuesed()
        {
            if (seacretWordUniqueCharCount == correctChars.Count)
            {
                return true;
            }
            return false;
        }

        public KeyGuessState GuessKey(char key)
        {
            if (guessedChars.Contains(key))
            {
                return KeyGuessState.AlreadyGuessed;
            }
            guessedChars.Add(key);
            if (seacretWord.Contains(key))
            {
                correctChars.Add(key);
                return KeyGuessState.Correct;
            }

            return KeyGuessState.Incorect;
        }

        public string GetHiddenWord()
        {
            string output = "";
            foreach (char c in seacretWord)
            {
                if (correctChars.Contains(c))
                {
                    output += c + " ";
                }
                else
                {
                    output += "__ ";
                }
            }
            return output;
        }
    }
}
