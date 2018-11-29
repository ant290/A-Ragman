using A_Ragman.Interfaces;
using System.Collections.Generic;

namespace A_Ragman.Helpers
{
    public class WordListGenerator : IWordListGenerator
    {
        /// <summary>
        /// Gets a list of WordListModels using hard coded list in ExampleWordList class
        /// </summary>
        /// <returns>List<WordListModel></returns>
        public IEnumerable<IWordListModel> GetWords()
        {
            var words = new ExampleWordList();
            return words.exampleList;
        }
    }
}
