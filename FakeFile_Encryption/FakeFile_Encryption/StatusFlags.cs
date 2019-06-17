using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeFile_Encryption
{
    public class StatusFlags
    {
        public enum Type
        {
            OK,
            Warning,
            Exception,
        }

        public Type TypeCheck(string path)
        {
            if (System.IO.File.Exists(path))
                return Type.OK;
            else
                return Type.Exception;
        }

        public enum Stage
        {
            Load_Initial = 1,
            Load_OriginalFile = 2,
            Load_PackFile = 3,
            Load_FakeFile = 4,
            Load_keyFile = 5,
            Load_SaveFile = 6
        }
        public enum ProgressTime
        {
            TimeMinimum=1,
            TimeMaximum=30,
            TimeStep=1
        }
        public Type FolderType;
        public Stage WorkSatge;

        public String sourceFilePath = null;
        public String fakeFilePath = null;
        public String newFilePath = null;
        public String fileNameExtension = null;
        public String packFilePath = null;
        public String keyFilePath = null;
 

    }


}
