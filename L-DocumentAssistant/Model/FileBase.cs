using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L_DocumentAssistant.Global;
using System.Diagnostics;
using System.IO;

namespace L_DocumentAssistant.Model
{
    public abstract class FileBase
    {
        private Guid guid;
        private string name;
        private string fullPath;
        private Constant.FileType type;

        public Guid GUID
        {
            get
            {
                return guid;
            }
        }

        public string Name
        {
            get
            {
                return getName();
            }
        }

        protected abstract string getName();

        public string FullPath
        {
            get
            {
                return fullPath;
            }
        }

        public Constant.FileType Type
        {
            get
            {
                return getType();
            }
        }

        protected abstract Constant.FileType getType();

        public DateTime LastModified
        {
            get
            {
                return getLastModifiedTime();
            }
        }

        protected abstract DateTime getLastModifiedTime();

        public DateTime CreateTime
        {
            get
            {
                return getCreateTime();
            }
        }

        protected abstract DateTime getCreateTime();


        public FileBase(string path)
        {
            guid = new Guid();
            getFileInfo(path);
        }

        private void getFileInfo(string path)
        {
            fullPath = path;
        }

        public override string ToString()
        {
            return fullPath;
        }
    }
}
