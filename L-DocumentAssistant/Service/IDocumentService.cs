using L_DocumentAssistant.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_DocumentAssistant.Service
{
    public interface IDocumentService
    {
        bool StartIndex(IList<Folder> folders, bool recursive = true);

        bool StopIndex();

        ObservableCollection<string> Search(string keyWordsString);
    }
}
