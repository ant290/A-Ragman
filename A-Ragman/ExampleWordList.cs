using System;
using System.Collections.Generic;
using System.Text;

namespace A_Ragman
{
    /// <summary>
    /// hard coded list of words for example program
    /// </summary>
    public class ExampleWordList
    {
        public List<WordListModel> exampleList = new List<WordListModel>();

        public ExampleWordList()
        {
            exampleList.Add(new WordListModel("leap", "pale"));
            exampleList.Add(new WordListModel("paws", "swap"));
            exampleList.Add(new WordListModel("wasp", "shop"));
        }

    }
}
