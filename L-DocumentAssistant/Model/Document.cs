using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L_DocumentAssistant.Global;

namespace L_DocumentAssistant.Model
{
    public class Document: FileBase
    {
        private long size;

        public long Size
        {
            get
            {
                return size;
            }
        }

        private string extension;

        public string Extension
        {
            get
            {
                return extension;
            }
        }

        public Document(string path):base(path)
        {
            FileInfo fileInfo = new FileInfo(path);
            size = fileInfo.Length;
            extension = fileInfo.Extension;
        }

        protected override DateTime getCreateTime()
        {
            return File.GetCreationTime(FullPath);
        }

        protected override DateTime getLastModifiedTime()
        {
            return File.GetLastWriteTime(FullPath);
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", Name, Type, FullPath, CreateTime, LastModified, Size);
        }

        protected override string getName()
        {
            return Path.GetFileName(FullPath);
        }

        protected override Constant.FileType getType()
        {
            return Constant.FileType.DOCUMENT;
        }
    }
}
