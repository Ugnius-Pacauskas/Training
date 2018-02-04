using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HangedMan
{
    class WordsContainer
    {
        private string[] words;

        public WordsContainer ()
        {
            words = File.ReadAllLines("word.txt");
        }
    }
}
