using System.Collections.Generic;

namespace A_Ragman.Interfaces
{
    public interface IWordListGenerator
    {
        IEnumerable<IWordListModel> GetWords();
    }
}
