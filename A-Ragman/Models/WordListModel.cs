using A_Ragman.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace A_Ragman
{
    public class WordListModel : IWordListModel
    {
        private string _word1;
        private string _word2;
        public string word1 { get => _word1; set => _word1 = value; }
        public string word2 { get => _word2; set => _word2 = value; }

        //doesn't really need a constructor as using public get / set but other implementations might want it
        public WordListModel(string wrd1, string wrd2)
        {
            _word1 = wrd1;
            _word2 = wrd2;
        }

        
    }
}
