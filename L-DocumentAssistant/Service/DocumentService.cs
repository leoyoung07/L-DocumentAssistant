using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L_DocumentAssistant.Model;

namespace L_DocumentAssistant.Service
{
    public class DocumentService : IDocumentService
    {
        public ObservableCollection<string> Search(string keyWordsString)
        {
            throw new NotImplementedException();
        }

        public bool StartIndex(IList<Folder> folders, bool recursive = true)
        {
            throw new NotImplementedException();
        }

        public bool StopIndex()
        {
            throw new NotImplementedException();
        }
    }
}
