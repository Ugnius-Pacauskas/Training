using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HangedManWPF
{
    class WordsContainer
    {
        private string[] words;

        public WordsContainer()
        {
            words = File.ReadAllLines("words.txt");
        }

        public string GetRandomWord()
        {
            Random random = new Random();
            return words[random.Next(words.Length - 1)];
        }
    }
}

