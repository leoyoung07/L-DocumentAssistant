using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using L_DocumentAssistant.Global;

namespace L_DocumentAssistant.Model
{
    public class Folder: FileBase
    {
        private ObservableCollection<Document> documents;

        public ObservableCollection<Document> Documents
        {
            get
            {
                return documents;
            }
        }

        private ObservableCollection<Folder> folders = null;

        public ObservableCollection<Folder> Folders
        {
            get
            {
                if(folders == null)
                {
                    folders = new ObservableCollection<Folder>();
                    foreach (var folder in Directory.GetDirectories(FullPath))
                    {
                        folders.Add(new Folder(FullPath));
                    }
                }
                return folders;
            }
        }

        public Folder(string path) : base(path)
        {
            documents = new ObservableCollection<Document>();
            foreach (var file in Directory.GetFiles(path))
            {
                documents.Add(new Document(file));
            }
        }

        protected override DateTime getLastModifiedTime()
        {
            return Directory.GetCreationTime(FullPath);
        }

        protected override DateTime getCreateTime()
        {
            return Directory.GetLastWriteTime(FullPath);
        }


        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", Name, Type, FullPath, CreateTime, LastModified, Documents.Count, Folders.Count);
        }

        protected override string getName()
        {
            char spliter = '/';
            if(FullPath.Contains(@"\"))
            {
                spliter = '\\';
            }
            string path = FullPath.TrimEnd(spliter);
            int nameBegin = path.LastIndexOf(spliter) + 1;
            return path.Substring(nameBegin);
        }

        protected override Constant.FileType getType()
        {
            return Constant.FileType.FOLDER;
        }
    }
}
